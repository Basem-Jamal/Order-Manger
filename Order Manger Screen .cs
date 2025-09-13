using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var order = Data.orders[index];
            lblOrderId.Text = order.id.ToString();

            // تفريغ الجدول
            tableLayoutPanelProducts.Controls.Clear();
            tableLayoutPanelProducts.RowStyles.Clear();
            tableLayoutPanelProducts.ColumnCount = 3;
            tableLayoutPanelProducts.RowCount = 1;
            tableLayoutPanelProducts.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableLayoutPanelProducts.RightToLeft = RightToLeft.Yes;
            tableLayoutPanelProducts.AutoSize = true;

            // إضافة العناوين
            tableLayoutPanelProducts.Controls.Add(CreateHeaderLabel("المنتج"), 0, 0);
            tableLayoutPanelProducts.Controls.Add(CreateHeaderLabel("الكود"), 1, 0);
            tableLayoutPanelProducts.Controls.Add(CreateHeaderLabel("السعر"), 2, 0);

            int row = 1;
            foreach (var p in order.products)
            {
                tableLayoutPanelProducts.RowCount++;

                tableLayoutPanelProducts.Controls.Add(CreateCellLabel(p.name), 0, row);
                tableLayoutPanelProducts.Controls.Add(CreateCellLabel(p.sku), 1, row);

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
                Anchor = AnchorStyles.None
            };
        }

        //private void ShowOrder(int index)
        //{
        //    var order = Data.orders[index];
        //    lblOrderId.Text = order.id.ToString();
        //    currentShipping.Text = order.shipping_company;

        //    string productsText = "";
        //    string barcodeText = "";
        //    int quantity = 0;


        //    foreach (var p in order.products)
        //    {
        //        productsText = p.name;
        //        barcodeText = p.sku;
        //        quantity = p.qty;

        //    }

        //    labelProduct.Text = productsText;
        //    labelBarcode.Text = barcodeText;
        //}

        //private void ShowOrder(int index)
        //{
        //    var order = Data.orders[index];
        //    lblOrderId.Text = order.id.ToString();

        //    // تفريغ المنتجات القديمة
        //    flowLayoutPanelProducts.Controls.Clear();

        //    foreach (var p in order.products)
        //    {
        //        // Panel لكل منتج
        //        Panel productPanel = new Panel();
        //        productPanel.AutoSize = true;
        //        productPanel.BackColor = Color.Black;
        //        productPanel.RightToLeft = RightToLeft.Yes;

        //        // Label للمنتج
        //        Label lblName = new Label();
        //        lblName.Text = $"المنتج: {p.name}";
        //        lblName.AutoSize = true;
        //        lblName.ForeColor = Color.White;
        //        lblName.Font = new Font("Tahoma", 12, FontStyle.Bold);

        //        // Label للكود
        //        Label lblCode = new Label();
        //        lblCode.Text = $"الكود: {p.sku}";
        //        lblCode.AutoSize = true;
        //        lblCode.ForeColor = Color.White;
        //        lblCode.Font = new Font("Tahoma", 12, FontStyle.Regular);

        //        // Label للكمية
        //        Label lblQty = new Label();
        //        lblQty.Text = $"الكمية: {p.qty}";
        //        lblQty.AutoSize = true;
        //        lblQty.ForeColor = Color.White;
        //        lblQty.Font = new Font("Tahoma", 12, FontStyle.Regular);

        //        // Label للسعر
        //        //Label lblPrice = new Label();
        //        //lblPrice.Text = $"السعر: {p.price}";
        //        //lblPrice.AutoSize = true;
        //        //lblPrice.ForeColor = Color.White;
        //        //lblPrice.Font = new Font("Tahoma", 12, FontStyle.Regular);

        //        // ترتيب العناصر داخل Panel (من اليمين لليسار)
        //        FlowLayoutPanel row = new FlowLayoutPanel();
        //        row.FlowDirection = FlowDirection.RightToLeft;
        //        row.AutoSize = true;
        //        row.Controls.Add(lblName);
        //        row.Controls.Add(lblCode);
        //        row.Controls.Add(lblQty);

        //        productPanel.Controls.Add(row);

        //        // إضافة الـ Panel للـ FlowLayoutPanel الرئيسي
        //        flowLayoutPanelProducts.Controls.Add(productPanel);
        //    }
        //}

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
            labelTitlePrice.ForeColor   = Color.White;

            //
            labelProduct.ForeColor = Color.White;
            labelBarcode.ForeColor = Color.White;
            labelPrice.ForeColor = Color.White;
        }
        private void panelAndDataGridViewEditBackg ()
        {
            panelProductsData.BackColor = Color.FromArgb(255, 44, 83, 100); // #2C5364
            panelProductsData.BackColor = Color.FromArgb(255, 32, 58, 67);  // #203A43

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
    }
}
