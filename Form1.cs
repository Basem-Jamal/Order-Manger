using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static Order_Manager.Form1;


namespace Order_Manager
{

    public partial class Form1 : Form
    {

        Root Data;

        string path = @"C:\Users\user\source\repos\14 - C# - Level 1\Desktop app\Order Manager\orders.json";

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


        public class Product
        {
            public string sku { get; set; }
            public string name { get; set; }
            public int qty { get; set; }
        }

        string[] statusFlow = new string[]
            {
                "بإنتظار المراجعة",
                "جاري التنفيذ",
                "تم التنفيذ",
                "تم التسليم للمندوب"
            };

        public Form1()
        {
            InitializeComponent();
            dgvOrders.CellValueChanged += dgvOrders_CellValueChanged;
            dgvOrders.CurrentCellDirtyStateChanged += dgvOrders_CurrentCellDirtyStateChanged;

        }

        bool loadingData = false;


        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadingData = true;

            string json = File.ReadAllText(path);

            Data = JsonSerializer.Deserialize<Root>(json);


            dgvOrders.DataSource = Data.orders;

            dgvOrders.RowHeadersVisible = false;


            if (dgvOrders.Columns["status"] != null)
                dgvOrders.Columns["status"].Visible = false;

            if (dgvOrders.Columns["payment_method"] != null)
                dgvOrders.Columns["payment_method"].Visible = false;

            if (dgvOrders.Columns["assigned_user"] != null)
                dgvOrders.Columns["assigned_user"].Visible = false;

            if (dgvOrders.Columns["cod_fee"] != null)
                dgvOrders.Columns["cod_fee"].Visible = false;


            if (!dgvOrders.Columns.Contains("ProductsList"))
            {
                dgvOrders.Columns.Add("ProductsList", "Products List");

            }


            if (!dgvOrders.Columns.Contains("statusCombo"))
            {
                DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
                statusColumn.Name = "statusCombo";
                statusColumn.HeaderText = "الحالة";
                statusColumn.DataSource = new string[]
                {
                      "بإنتظار المراجعة",
                     "جاري التنفيذ",
                     "تم التنفيذ",
                      "تم التسليم للمندوب"

                };

                dgvOrders.Columns.Add(statusColumn);
            }

            foreach(DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.IsNewRow) continue;

                var order = row.DataBoundItem as Order;

                if (order == null) continue;

                row.Cells["statusCombo"].Value = order.status;
            }



            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.IsNewRow) continue;

                var order = row.DataBoundItem as Order;


                var part = order.products?.Select(p => $" الصنف {p.name}  الكمية {p.qty}  ");
                if (order.products == null || order.products.Count == 0)
                {
                    row.Cells["ProductsList"].Value = "لا توجد منتجات";
                }


                string ProductsText = string.Join(", ", part);

                row.Cells["ProductsList"].Value = ProductsText;

            }

            loadingData = false;

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

        private void dgvOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrders.IsCurrentCellDirty)
                dgvOrders.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (loadingData) return; // تجاهل الأحداث أثناء التحميل

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvOrders.Columns[e.ColumnIndex].Name == "statusCombo")
            {
                var row = dgvOrders.Rows[e.RowIndex];
                var order = row.DataBoundItem as Order;
               
                if (order != null)
                {
                    string newStatus = row.Cells["statusCombo"].Value?.ToString();
                    order.status = newStatus;

                    // تحديث أوقات المراحل
                    if (newStatus == "بإنتظار المراجعة")
                        order.receivedTime = DateTime.Now;
                    else if (newStatus == "جاري التنفيذ")
                        order.processingTime = DateTime.Now;
                    else if (newStatus == "تم التنفيذ")
                        order.completedTime = DateTime.Now;
                    else if (newStatus == "تم التسليم للمندوب")
                        order.deliveredTime = DateTime.Now;

                    // حفظ الكل في الملف
                    var orders = (dgvOrders.DataSource as List<Order>);
                    if (orders != null)
                    {
                        SaveOrders(orders);
                    }

                    MessageBox.Show("تم الحفظ في الملف ✅");
                }
            }
        }

    }
}
