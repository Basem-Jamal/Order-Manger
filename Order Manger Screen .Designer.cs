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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Manger_Screen));
            lblTitleShipping = new Label();
            label2 = new Label();
            currentShipping = new Label();
            lblOrderId = new Label();
            panelProductsData = new DoubleBufferedPanel();
            tableLayoutPanelProducts = new DoubleBufferedTableLayoutPanel();
            panelHeaderTextTable = new Panel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            labelTitleProduct = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            labelTitleBarcode = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            labelTitleQuantity = new Label();
            backgroundPanel = new GradientPanel();
            btnNext = new Button();
            panelinfoCOUST = new Panel();
            labelCoustAddress = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            labelCOUSTNum = new Label();
            labelCOUSTName = new Label();
            panelHeader = new DoubleBufferedPanel();
            lblTitleOrderNum = new Label();
            btnPrev = new Button();
            panelProductsData.SuspendLayout();
            panelHeaderTextTable.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            backgroundPanel.SuspendLayout();
            panelinfoCOUST.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleShipping
            // 
            resources.ApplyResources(lblTitleShipping, "lblTitleShipping");
            lblTitleShipping.ForeColor = Color.White;
            lblTitleShipping.Name = "lblTitleShipping";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // currentShipping
            // 
            resources.ApplyResources(currentShipping, "currentShipping");
            currentShipping.ForeColor = Color.White;
            currentShipping.Name = "currentShipping";
            // 
            // lblOrderId
            // 
            resources.ApplyResources(lblOrderId, "lblOrderId");
            lblOrderId.ForeColor = Color.White;
            lblOrderId.Name = "lblOrderId";
            // 
            // panelProductsData
            // 
            resources.ApplyResources(panelProductsData, "panelProductsData");
            panelProductsData.BackColor = Color.Gainsboro;
            panelProductsData.Controls.Add(tableLayoutPanelProducts);
            panelProductsData.Name = "panelProductsData";
            // 
            // tableLayoutPanelProducts
            // 
            resources.ApplyResources(tableLayoutPanelProducts, "tableLayoutPanelProducts");
            tableLayoutPanelProducts.BackColor = Color.Gray;
            tableLayoutPanelProducts.Name = "tableLayoutPanelProducts";
            // 
            // panelHeaderTextTable
            // 
            resources.ApplyResources(panelHeaderTextTable, "panelHeaderTextTable");
            panelHeaderTextTable.BackColor = Color.Transparent;
            panelHeaderTextTable.Controls.Add(flowLayoutPanel8);
            panelHeaderTextTable.Controls.Add(flowLayoutPanel7);
            panelHeaderTextTable.Controls.Add(flowLayoutPanel9);
            panelHeaderTextTable.Name = "panelHeaderTextTable";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(labelTitleProduct);
            resources.ApplyResources(flowLayoutPanel8, "flowLayoutPanel8");
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            // 
            // labelTitleProduct
            // 
            resources.ApplyResources(labelTitleProduct, "labelTitleProduct");
            labelTitleProduct.Name = "labelTitleProduct";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(labelTitleBarcode);
            resources.ApplyResources(flowLayoutPanel7, "flowLayoutPanel7");
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            // 
            // labelTitleBarcode
            // 
            resources.ApplyResources(labelTitleBarcode, "labelTitleBarcode");
            labelTitleBarcode.Name = "labelTitleBarcode";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(labelTitleQuantity);
            resources.ApplyResources(flowLayoutPanel9, "flowLayoutPanel9");
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            // 
            // labelTitleQuantity
            // 
            resources.ApplyResources(labelTitleQuantity, "labelTitleQuantity");
            labelTitleQuantity.Name = "labelTitleQuantity";
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.Transparent;
            backgroundPanel.Color1 = Color.FromArgb(44, 62, 80);
            backgroundPanel.Color2 = Color.FromArgb(189, 195, 199);
            backgroundPanel.Controls.Add(btnPrev);
            backgroundPanel.Controls.Add(btnNext);
            backgroundPanel.Controls.Add(panelinfoCOUST);
            backgroundPanel.Controls.Add(panelProductsData);
            backgroundPanel.Controls.Add(panelHeaderTextTable);
            backgroundPanel.Controls.Add(panelHeader);
            resources.ApplyResources(backgroundPanel, "backgroundPanel");
            backgroundPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            backgroundPanel.Name = "backgroundPanel";
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // panelinfoCOUST
            // 
            resources.ApplyResources(panelinfoCOUST, "panelinfoCOUST");
            panelinfoCOUST.BackColor = Color.Gray;
            panelinfoCOUST.Controls.Add(labelCoustAddress);
            panelinfoCOUST.Controls.Add(label4);
            panelinfoCOUST.Controls.Add(label3);
            panelinfoCOUST.Controls.Add(label1);
            panelinfoCOUST.Controls.Add(labelCOUSTNum);
            panelinfoCOUST.Controls.Add(labelCOUSTName);
            panelinfoCOUST.Name = "panelinfoCOUST";
            // 
            // labelCoustAddress
            // 
            resources.ApplyResources(labelCoustAddress, "labelCoustAddress");
            labelCoustAddress.BackColor = Color.Transparent;
            labelCoustAddress.ForeColor = Color.White;
            labelCoustAddress.Name = "labelCoustAddress";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // labelCOUSTNum
            // 
            resources.ApplyResources(labelCOUSTNum, "labelCOUSTNum");
            labelCOUSTNum.BackColor = Color.Transparent;
            labelCOUSTNum.ForeColor = Color.White;
            labelCOUSTNum.Name = "labelCOUSTNum";
            // 
            // labelCOUSTName
            // 
            resources.ApplyResources(labelCOUSTName, "labelCOUSTName");
            labelCOUSTName.BackColor = Color.Transparent;
            labelCOUSTName.ForeColor = Color.White;
            labelCOUSTName.Name = "labelCOUSTName";
            // 
            // panelHeader
            // 
            resources.ApplyResources(panelHeader, "panelHeader");
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(lblTitleShipping);
            panelHeader.Controls.Add(currentShipping);
            panelHeader.Controls.Add(lblTitleOrderNum);
            panelHeader.Controls.Add(lblOrderId);
            panelHeader.Name = "panelHeader";
            // 
            // lblTitleOrderNum
            // 
            resources.ApplyResources(lblTitleOrderNum, "lblTitleOrderNum");
            lblTitleOrderNum.ForeColor = Color.White;
            lblTitleOrderNum.Name = "lblTitleOrderNum";
            // 
            // btnPrev
            // 
            resources.ApplyResources(btnPrev, "btnPrev");
            btnPrev.Name = "btnPrev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // Order_Manger_Screen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundPanel);
            ForeColor = SystemColors.ControlText;
            Name = "Order_Manger_Screen";
            WindowState = FormWindowState.Maximized;
            Load += Order_Manger_Screen_Load;
            panelProductsData.ResumeLayout(false);
            panelHeaderTextTable.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            panelinfoCOUST.ResumeLayout(false);
            panelinfoCOUST.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblTitleShipping;
        private Label label2;
        private Label currentShipping;
        private Label lblOrderId;
        private DoubleBufferedPanel panelProductsData;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label labelPrice;
        private FlowLayoutPanel flowLayoutPanel12;
        private Label labelBarcode;
        private Label labelProduct;
        private DoubleBufferedTableLayoutPanel tableLayoutPanelProducts;
        private Panel panelHeaderTextTable;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label labelTitleProduct;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label labelTitleBarcode;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label labelTitleQuantity;
        private GradientPanel backgroundPanel;
        private DoubleBufferedPanel panelHeader;
        private Label lblTitleOrderNum;
        private Panel panelinfoCOUST;
        private Label labelCOUSTName;
        private Label label1;
        private Label labelCoustAddress;
        private Label labelCOUSTNum;
        private Label label4;
        private Label label3;
        private Button btnNext;
        private Button btnPrev;
    }
}