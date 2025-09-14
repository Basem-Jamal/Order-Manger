namespace Order_Manager
{
    partial class Order_Manger_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ش = new Label();
            label2 = new Label();
            currentShipping = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            s = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblOrderId = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            panelProductsData = new Panel();
            tableLayoutPanelProducts = new TableLayoutPanel();
            panelHeaderTextTable = new Panel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            labelTitleProduct = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            labelTitleBarcode = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            labelTitleQuantity = new Label();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            panelProductsData.SuspendLayout();
            panelHeaderTextTable.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // ش
            // 
            ش.AutoSize = true;
            ش.Dock = DockStyle.Fill;
            ش.Font = new Font("Segoe UI", 30F);
            ش.Location = new Point(3, 0);
            ش.Name = "ش";
            ش.Size = new Size(224, 54);
            ش.TabIndex = 0;
            ش.Text = "شركة الشحن";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 47);
            label2.TabIndex = 2;
            label2.Text = "الفاتورة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentShipping
            // 
            currentShipping.AutoSize = true;
            currentShipping.Dock = DockStyle.Fill;
            currentShipping.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentShipping.Location = new Point(3, 0);
            currentShipping.Name = "currentShipping";
            currentShipping.Size = new Size(120, 47);
            currentShipping.TabIndex = 5;
            currentShipping.Text = "اليمامة";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(s);
            flowLayoutPanel3.Location = new Point(1721, 31);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(260, 76);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // s
            // 
            s.AutoSize = true;
            s.Dock = DockStyle.Fill;
            s.Font = new Font("Segoe UI", 30F);
            s.Location = new Point(3, 0);
            s.Name = "s";
            s.Size = new Size(197, 54);
            s.TabIndex = 12;
            s.Text = "رقم الطلب";
            s.TextAlign = ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(lblOrderId);
            flowLayoutPanel1.Location = new Point(1435, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(280, 61);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Dock = DockStyle.Fill;
            lblOrderId.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderId.Location = new Point(3, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(252, 47);
            lblOrderId.TabIndex = 3;
            lblOrderId.Text = "لايوجد رقم طلب";
            lblOrderId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(873, 53);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 69);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(ش);
            flowLayoutPanel4.Location = new Point(408, 31);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(290, 76);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(currentShipping);
            flowLayoutPanel5.Location = new Point(92, 46);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(310, 61);
            flowLayoutPanel5.TabIndex = 11;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Location = new Point(95, 327);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(332, 473);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // panelProductsData
            // 
            panelProductsData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelProductsData.AutoScroll = true;
            panelProductsData.BackColor = Color.Transparent;
            panelProductsData.Controls.Add(tableLayoutPanelProducts);
            panelProductsData.Location = new Point(819, 304);
            panelProductsData.Name = "panelProductsData";
            panelProductsData.Size = new Size(1141, 531);
            panelProductsData.TabIndex = 13;
            // 
            // tableLayoutPanelProducts
            // 
            tableLayoutPanelProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanelProducts.AutoScroll = true;
            tableLayoutPanelProducts.ColumnCount = 3;
            tableLayoutPanelProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.76968F));
            tableLayoutPanelProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.23032F));
            tableLayoutPanelProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 266F));
            tableLayoutPanelProducts.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanelProducts.Location = new Point(3, 12);
            tableLayoutPanelProducts.Name = "tableLayoutPanelProducts";
            tableLayoutPanelProducts.RightToLeft = RightToLeft.Yes;
            tableLayoutPanelProducts.RowCount = 1;
            tableLayoutPanelProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanelProducts.Size = new Size(1127, 492);
            tableLayoutPanelProducts.TabIndex = 14;
            // 
            // panelHeaderTextTable
            // 
            panelHeaderTextTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelHeaderTextTable.BackColor = Color.Transparent;
            panelHeaderTextTable.Controls.Add(flowLayoutPanel8);
            panelHeaderTextTable.Controls.Add(flowLayoutPanel7);
            panelHeaderTextTable.Controls.Add(flowLayoutPanel9);
            panelHeaderTextTable.Location = new Point(819, 202);
            panelHeaderTextTable.Name = "panelHeaderTextTable";
            panelHeaderTextTable.Size = new Size(1123, 96);
            panelHeaderTextTable.TabIndex = 15;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(labelTitleProduct);
            flowLayoutPanel8.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel8.Location = new Point(754, 23);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(188, 46);
            flowLayoutPanel8.TabIndex = 0;
            // 
            // labelTitleProduct
            // 
            labelTitleProduct.AutoSize = true;
            labelTitleProduct.Font = new Font("Segoe UI", 26.25F);
            labelTitleProduct.Location = new Point(70, 0);
            labelTitleProduct.Name = "labelTitleProduct";
            labelTitleProduct.Size = new Size(115, 47);
            labelTitleProduct.TabIndex = 0;
            labelTitleProduct.Text = " المنتج";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(labelTitleBarcode);
            flowLayoutPanel7.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel7.Location = new Point(372, 24);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(188, 46);
            flowLayoutPanel7.TabIndex = 1;
            // 
            // labelTitleBarcode
            // 
            labelTitleBarcode.AutoSize = true;
            labelTitleBarcode.Font = new Font("Segoe UI", 26.25F);
            labelTitleBarcode.Location = new Point(90, 0);
            labelTitleBarcode.Name = "labelTitleBarcode";
            labelTitleBarcode.Size = new Size(95, 47);
            labelTitleBarcode.TabIndex = 0;
            labelTitleBarcode.Text = "الكود";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(labelTitleQuantity);
            flowLayoutPanel9.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel9.Location = new Point(23, 23);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(188, 46);
            flowLayoutPanel9.TabIndex = 1;
            // 
            // labelTitleQuantity
            // 
            labelTitleQuantity.AutoSize = true;
            labelTitleQuantity.Font = new Font("Segoe UI", 26.25F);
            labelTitleQuantity.Location = new Point(76, 0);
            labelTitleQuantity.Name = "labelTitleQuantity";
            labelTitleQuantity.Size = new Size(109, 47);
            labelTitleQuantity.TabIndex = 0;
            labelTitleQuantity.Text = "الكمية";
            // 
            // Order_Manger_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1993, 909);
            Controls.Add(panelHeaderTextTable);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(panelProductsData);
            Name = "Order_Manger_Screen";
            Text = "ادارة الطلبات";
            WindowState = FormWindowState.Maximized;
            Load += Order_Manger_Screen_Load;
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            panelProductsData.ResumeLayout(false);
            panelHeaderTextTable.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label ش;
        private Label label2;
        private Label currentShipping;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label s;
        private Label lblOrderId;
        private FlowLayoutPanel flowLayoutPanel6;
        private Panel panelProductsData;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label labelPrice;
        private FlowLayoutPanel flowLayoutPanel12;
        private Label labelBarcode;
        private Label labelProduct;
        private TableLayoutPanel tableLayoutPanelProducts;
        private Panel panelHeaderTextTable;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label labelTitleProduct;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label labelTitleBarcode;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label labelTitleQuantity;
    }
}