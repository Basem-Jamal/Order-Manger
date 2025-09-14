using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Order_Manager.Form1;


namespace Order_Manager
{


    public partial class Order_Manger_Screen : Form
    {



        Root Data;

        string path = @"C:\Users\basem\source\repos\14 - C# - Level 1\Desktop app\Order Manager\orders.json";

        public class Root
        {
            public List<Order> orders { get; set; }
        }

        public class Order
        {
            public long id { get; set; }
            public string status { get; set; }
            public string customer_name { get; set; }
            public string phone { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string sku_list { get; set; }
            public string payment_method { get; set; }
            public decimal cod_fee { get; set; }
            public decimal total { get; set; }
            public string order_date { get; set; }
            public string shipping_company { get; set; }
            public string address { get; set; }
            public List<Product> products { get; set; }
            public string assigned_user { get; set; }


            // ⬅️ إضافة الوقت لكل مرحلة

            public DateTime? receivedTime { get; set; }      // وقت وصول الطلب للموظف
            public DateTime? processingTime { get; set; }    // وقت بدء التنفيذ
            public DateTime? completedTime { get; set; }     // وقت انتهاء التنفيذ
            public DateTime? deliveredTime { get; set; }     // وقت تسليم المندوب

        }

        public Order_Manger_Screen()
        {


            InitializeComponent();

            // استبدال البانل العادي بتدرج
            GradientPanel gradientPanel = new GradientPanel();
            gradientPanel.Dock = DockStyle.Fill;

            // إذا كنت تريد أن يحل محل panelProductsData
            gradientPanel.Name = "panelProductsData";
            this.Controls.Remove(panelProductsData);
            this.Controls.Add(gradientPanel);
            panelProductsData = gradientPanel;

        }

        private void Order_Manger_Screen_Load(object sender, EventArgs e)
        {



            //START - Edit Background and Color For Panel , DataGridView , Text
            panelAndDataGridViewEditBackg();
            someLabelForEditColor();

            //END 



            LoadData();
            ShowOrder(1);
        }

        private void ShowOrder(int index)
        {

            // تفريغ الجدول تمامًا


            var order = Data.orders[index];
            lblOrderId.Text = order.id.ToString();

            // تفريغ الجدول
            tableLayoutPanelProducts.Controls.Clear();
            tableLayoutPanelProducts.RowStyles.Clear();
            tableLayoutPanelProducts.ColumnCount = 3;
            tableLayoutPanelProducts.RowCount = 0;
            tableLayoutPanelProducts.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableLayoutPanelProducts.RightToLeft = RightToLeft.Yes;
            tableLayoutPanelProducts.AutoSize = true;

            // إضافة العناوين
            //tableLayoutPanelProducts.Controls.Add(CreateHeaderLabel("المنتج"), 0, 0);
            //tableLayoutPanelProducts.Controls.Add(CreateHeaderLabel("الكود"), 1, 0);
            //tableLayoutPanelProducts.Controls.Add(CreateHeaderLabel("السعر"), 2, 0);

            int row = 1;
            foreach (var p in order.products)
            {
                tableLayoutPanelProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));

                tableLayoutPanelProducts.RowCount++;

                tableLayoutPanelProducts.Controls.Add(CreateCellLabel(p.name), 0, row);
                tableLayoutPanelProducts.Controls.Add(CreateCellLabel(p.sku), 1, row);
                tableLayoutPanelProducts.Controls.Add(CreateCellLabel(p.qty.ToString()), 2, row);


                row++;
            }
        }

        private Label CreateHeaderLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Tahoma", 26, FontStyle.Bold),
                Anchor = AnchorStyles.None
            };
        }

        private Label CreateCellLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Tahoma", 16, FontStyle.Regular),
                Anchor = AnchorStyles.None,
                Margin = new Padding(20) // مسافة خفيفة
            };
        }



        private void LoadData()
        {
            string json = File.ReadAllText(path);
            Data = JsonSerializer.Deserialize<Root>(json);

        }




        private void SaveOrders(List<Order> orders)
        {
            var root = new Root { orders = orders };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(root, options);

            File.WriteAllText(path, json);
        }

        bool loadingData = false;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Colors 
        private void someLabelForEditColor()
        {
            //Header
            labelTitleProduct.ForeColor = Color.White;
            labelTitleBarcode.ForeColor = Color.White;
            labelTitleQuantity.ForeColor = Color.White;

            ////
            //labelProduct.ForeColor = Color.White;
            //labelBarcode.ForeColor = Color.White;
            //labelPrice.ForeColor = Color.White;
        }
        private void panelAndDataGridViewEditBackg()
        {
            panelHeaderTextTable.BackColor = Color.FromArgb(255, 44, 83, 100); // #2C5364
            panelHeaderTextTable.BackColor = Color.FromArgb(255, 32, 58, 67);  // #203A43



        }


        // Edit Background Color For Palne
        //public void SetGradientBackground(Panel panel)
        //{

        //    panel.Paint += (s, e) =>
        //    {
        //        // الألوان مثل ما عندك في CSS (#2c3e50 -> #bdc3c7)
        //        Color color1 = ColorTranslator.FromHtml("#2c3e50");
        //        Color color2 = ColorTranslator.FromHtml("#bdc3c7");

        //        // اتجاه التدرج (من اليسار لليمين: 0 درجة)
        //        using (LinearGradientBrush brush = new LinearGradientBrush(
        //            panel.ClientRectangle,
        //            color1,
        //            color2,
        //            LinearGradientMode.Horizontal))
        //        {
        //            e.Graphics.FillRectangle(brush, panel.ClientRectangle);
        //        }
        //    };

        //}

    }


}
//private void dgvOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
//{
//    if (dgvOrders.IsCurrentCellDirty)
//        dgvOrders.CommitEdit(DataGridViewDataErrorContexts.Commit);
//}

//private void dgvOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
//{
//    if (loadingData) return; // تجاهل الأحداث أثناء التحميل

//    if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

//    if (dgvOrders.Columns[e.ColumnIndex].Name == "statusCombo")
//    {
//        var row = dgvOrders.Rows[e.RowIndex];
//        var order = row.DataBoundItem as Order;

//        if (order != null)
//        {
//            string newStatus = row.Cells["statusCombo"].Value?.ToString();
//            order.status = newStatus;

//            // تحديث أوقات المراحل
//            if (newStatus == "بإنتظار المراجعة")
//                order.receivedTime = DateTime.Now;
//            else if (newStatus == "جاري التنفيذ")
//                order.processingTime = DateTime.Now;
//            else if (newStatus == "تم التنفيذ")
//                order.completedTime = DateTime.Now;
//            else if (newStatus == "تم التسليم للمندوب")
//                order.deliveredTime = DateTime.Now;

//            // حفظ الكل في الملف
//            var orders = (dgvOrders.DataSource as List<Order>);
//            if (orders != null)
//            {
//                SaveOrders(orders);
//            }

//            MessageBox.Show("تم الحفظ في الملف ✅");
//        }
//    }
//}
