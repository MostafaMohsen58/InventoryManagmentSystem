namespace PresentationLayer
{
    partial class AdminDashBoard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            ReceiveSale = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            BTN_OK = new MaterialSkin.Controls.MaterialButton();
            AddProduct = new MaterialSkin.Controls.MaterialButton();
            dgv_SaleDetails = new DataGridView();
            dgv_Sale = new DataGridView();
            lblQty = new MaterialSkin.Controls.MaterialLabel();
            n_QTY = new NumericUpDown();
            CB_Product = new MaterialSkin.Controls.MaterialComboBox();
            Lbl_Product = new MaterialSkin.Controls.MaterialLabel();
            Txt_CName = new MaterialSkin.Controls.MaterialTextBox();
            Cust_Name = new MaterialSkin.Controls.MaterialLabel();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage4 = new TabPage();
            Receive_sale = new TabPage();
            btn_Receive_sale = new MaterialSkin.Controls.MaterialButton();
            myshoereport = new Microsoft.Web.WebView2.WinForms.WebView2();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            CB_SALES = new MaterialSkin.Controls.MaterialComboBox();
            ReceiveSale.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SaleDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Sale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_QTY).BeginInit();
            Receive_sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myshoereport).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-dashboard-layout-24.png");
            imageList1.Images.SetKeyName(1, "icons8-home-24.png");
            imageList1.Images.SetKeyName(2, "icons8-us-dollar-26.png");
            imageList1.Images.SetKeyName(3, "icons8-product-24.png");
            imageList1.Images.SetKeyName(4, "icons8-analytics-32.png");
            imageList1.Images.SetKeyName(5, "icons8-supplier-24.png");
            imageList1.Images.SetKeyName(6, "icons8-reports-32.png");
            imageList1.Images.SetKeyName(7, "icons8-users-24.png");
            imageList1.Images.SetKeyName(8, "icons8-stock-32.png");
            // 
            // ReceiveSale
            // 
            ReceiveSale.Controls.Add(tabPage1);
            ReceiveSale.Controls.Add(tabPage2);
            ReceiveSale.Controls.Add(tabPage3);
            ReceiveSale.Controls.Add(tabPage5);
            ReceiveSale.Controls.Add(tabPage6);
            ReceiveSale.Controls.Add(tabPage7);
            ReceiveSale.Controls.Add(tabPage8);
            ReceiveSale.Controls.Add(tabPage4);
            ReceiveSale.Controls.Add(Receive_sale);
            ReceiveSale.Depth = 0;
            ReceiveSale.Dock = DockStyle.Fill;
            ReceiveSale.ImageList = imageList1;
            ReceiveSale.Location = new Point(3, 58);
            ReceiveSale.MouseState = MaterialSkin.MouseState.HOVER;
            ReceiveSale.Multiline = true;
            ReceiveSale.Name = "ReceiveSale";
            ReceiveSale.SelectedIndex = 0;
            ReceiveSale.Size = new Size(1025, 636);
            ReceiveSale.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(materialFloatingActionButton3);
            tabPage1.Controls.Add(materialCard3);
            tabPage1.Controls.Add(materialFloatingActionButton2);
            tabPage1.Controls.Add(materialCard2);
            tabPage1.Controls.Add(materialFloatingActionButton1);
            tabPage1.Controls.Add(materialCard1);
            tabPage1.ImageKey = "icons8-dashboard-layout-24.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1017, 601);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 285);
            dataGridView1.TabIndex = 6;
            // 
            // materialFloatingActionButton3
            // 
            materialFloatingActionButton3.Depth = 0;
            materialFloatingActionButton3.Icon = (Image)resources.GetObject("materialFloatingActionButton3.Icon");
            materialFloatingActionButton3.Location = new Point(890, 75);
            materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            materialFloatingActionButton3.Size = new Size(59, 71);
            materialFloatingActionButton3.TabIndex = 5;
            materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label3);
            materialCard3.Controls.Add(materialLabel6);
            materialCard3.Controls.Add(materialLabel3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(669, 56);
            materialCard3.Margin = new Padding(14, 13, 14, 13);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14, 13, 14, 13);
            materialCard3.Size = new Size(250, 95);
            materialCard3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(70, 43);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 4;
            label3.Text = "$200,000";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(88, 47);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(1, 0);
            materialLabel6.TabIndex = 3;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 13);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(81, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Total Profit";
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = (Image)resources.GetObject("materialFloatingActionButton2.Icon");
            materialFloatingActionButton2.Location = new Point(573, 75);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(59, 71);
            materialFloatingActionButton2.TabIndex = 3;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(353, 56);
            materialCard2.Margin = new Padding(14, 13, 14, 13);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 13, 14, 13);
            materialCard2.Size = new Size(250, 95);
            materialCard2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(75, 43);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 2;
            label2.Text = "$600,000";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 13);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(81, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Total Sales";
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.ForeColor = Color.White;
            materialFloatingActionButton1.Icon = (Image)resources.GetObject("materialFloatingActionButton1.Icon");
            materialFloatingActionButton1.Location = new Point(255, 75);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(59, 71);
            materialFloatingActionButton1.TabIndex = 1;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(35, 56);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(250, 95);
            materialCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 1;
            label1.Text = "60,000";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(105, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Total Products";
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "icons8-product-24.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1017, 601);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BTN_OK);
            tabPage3.Controls.Add(AddProduct);
            tabPage3.Controls.Add(dgv_SaleDetails);
            tabPage3.Controls.Add(dgv_Sale);
            tabPage3.Controls.Add(lblQty);
            tabPage3.Controls.Add(n_QTY);
            tabPage3.Controls.Add(CB_Product);
            tabPage3.Controls.Add(Lbl_Product);
            tabPage3.Controls.Add(Txt_CName);
            tabPage3.Controls.Add(Cust_Name);
            tabPage3.ImageKey = "icons8-us-dollar-26.png";
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1017, 601);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sales";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BTN_OK
            // 
            BTN_OK.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_OK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_OK.Depth = 0;
            BTN_OK.HighEmphasis = true;
            BTN_OK.Icon = null;
            BTN_OK.Location = new Point(260, 342);
            BTN_OK.Margin = new Padding(4, 6, 4, 6);
            BTN_OK.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_OK.Name = "BTN_OK";
            BTN_OK.NoAccentTextColor = Color.Empty;
            BTN_OK.Size = new Size(64, 36);
            BTN_OK.TabIndex = 17;
            BTN_OK.Text = "OK";
            BTN_OK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_OK.UseAccentColor = false;
            BTN_OK.UseVisualStyleBackColor = true;
            BTN_OK.Click += BTN_OK_Click;
            // 
            // AddProduct
            // 
            AddProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddProduct.Depth = 0;
            AddProduct.HighEmphasis = true;
            AddProduct.Icon = null;
            AddProduct.Location = new Point(87, 342);
            AddProduct.Margin = new Padding(4, 6, 4, 6);
            AddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            AddProduct.Name = "AddProduct";
            AddProduct.NoAccentTextColor = Color.Empty;
            AddProduct.Size = new Size(121, 36);
            AddProduct.TabIndex = 16;
            AddProduct.Text = "Add Product";
            AddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddProduct.UseAccentColor = false;
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddSale_Click;
            // 
            // dgv_SaleDetails
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dgv_SaleDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_SaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_SaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_SaleDetails.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_SaleDetails.EnableHeadersVisualStyles = false;
            dgv_SaleDetails.Location = new Point(252, 432);
            dgv_SaleDetails.Name = "dgv_SaleDetails";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_SaleDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_SaleDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.Maroon;
            dgv_SaleDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_SaleDetails.Size = new Size(700, 156);
            dgv_SaleDetails.TabIndex = 15;
            // 
            // dgv_Sale
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.IndianRed;
            dgv_Sale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Silver;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Sale.ColumnHeadersHeight = 29;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_Sale.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_Sale.EnableHeadersVisualStyles = false;
            dgv_Sale.Location = new Point(366, 56);
            dgv_Sale.Name = "dgv_Sale";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Silver;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_Sale.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_Sale.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.SelectionBackColor = Color.IndianRed;
            dgv_Sale.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Sale.Size = new Size(586, 322);
            dgv_Sale.TabIndex = 14;
            dgv_Sale.CellContentClick += dataGridView2_CellContentClick;
            dgv_Sale.RowHeaderMouseDoubleClick += dgv_Sale_RowHeaderMouseDoubleClick;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Depth = 0;
            lblQty.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQty.ForeColor = Color.White;
            lblQty.Location = new Point(38, 275);
            lblQty.MouseState = MaterialSkin.MouseState.HOVER;
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(61, 19);
            lblQty.TabIndex = 10;
            lblQty.Text = "Quantity";
            // 
            // n_QTY
            // 
            n_QTY.Location = new Point(175, 270);
            n_QTY.Name = "n_QTY";
            n_QTY.Size = new Size(150, 24);
            n_QTY.TabIndex = 9;
            // 
            // CB_Product
            // 
            CB_Product.AutoResize = false;
            CB_Product.BackColor = Color.FromArgb(255, 255, 255);
            CB_Product.Cursor = Cursors.Hand;
            CB_Product.Depth = 0;
            CB_Product.DrawMode = DrawMode.OwnerDrawVariable;
            CB_Product.DropDownHeight = 260;
            CB_Product.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Product.DropDownWidth = 121;
            CB_Product.FlatStyle = FlatStyle.Flat;
            CB_Product.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CB_Product.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CB_Product.FormattingEnabled = true;
            CB_Product.IntegralHeight = false;
            CB_Product.ItemHeight = 43;
            CB_Product.Location = new Point(175, 157);
            CB_Product.MaxDropDownItems = 6;
            CB_Product.MouseState = MaterialSkin.MouseState.OUT;
            CB_Product.Name = "CB_Product";
            CB_Product.Size = new Size(151, 49);
            CB_Product.StartIndex = 0;
            CB_Product.TabIndex = 8;
            // 
            // Lbl_Product
            // 
            Lbl_Product.AutoSize = true;
            Lbl_Product.Depth = 0;
            Lbl_Product.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Lbl_Product.ForeColor = Color.White;
            Lbl_Product.Location = new Point(38, 187);
            Lbl_Product.MouseState = MaterialSkin.MouseState.HOVER;
            Lbl_Product.Name = "Lbl_Product";
            Lbl_Product.Size = new Size(56, 19);
            Lbl_Product.TabIndex = 2;
            Lbl_Product.Text = "Product";
            // 
            // Txt_CName
            // 
            Txt_CName.AnimateReadOnly = false;
            Txt_CName.BorderStyle = BorderStyle.None;
            Txt_CName.Depth = 0;
            Txt_CName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Txt_CName.LeadingIcon = null;
            Txt_CName.Location = new Point(175, 56);
            Txt_CName.MaxLength = 50;
            Txt_CName.MouseState = MaterialSkin.MouseState.OUT;
            Txt_CName.Multiline = false;
            Txt_CName.Name = "Txt_CName";
            Txt_CName.Size = new Size(151, 36);
            Txt_CName.TabIndex = 1;
            Txt_CName.Text = "";
            Txt_CName.TrailingIcon = null;
            Txt_CName.UseTallSize = false;
            // 
            // Cust_Name
            // 
            Cust_Name.AutoSize = true;
            Cust_Name.Depth = 0;
            Cust_Name.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Cust_Name.ForeColor = Color.White;
            Cust_Name.Location = new Point(38, 73);
            Cust_Name.MouseState = MaterialSkin.MouseState.HOVER;
            Cust_Name.Name = "Cust_Name";
            Cust_Name.Size = new Size(111, 19);
            Cust_Name.TabIndex = 0;
            Cust_Name.Text = "CustomerName";
            // 
            // tabPage5
            // 
            tabPage5.ImageKey = "icons8-stock-32.png";
            tabPage5.Location = new Point(4, 31);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1017, 601);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Stock";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.ImageKey = "icons8-supplier-24.png";
            tabPage6.Location = new Point(4, 31);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1017, 601);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Suppliers";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.ImageKey = "icons8-users-24.png";
            tabPage7.Location = new Point(4, 31);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1017, 601);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Users";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.ImageKey = "icons8-reports-32.png";
            tabPage8.Location = new Point(4, 31);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1017, 601);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Reports";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 31);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1017, 601);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Settings | Logout";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Receive_sale
            // 
            Receive_sale.Controls.Add(CB_SALES);
            Receive_sale.Controls.Add(btn_Receive_sale);
            Receive_sale.Controls.Add(myshoereport);
            Receive_sale.Location = new Point(4, 31);
            Receive_sale.Name = "Receive_sale";
            Receive_sale.Padding = new Padding(3);
            Receive_sale.Size = new Size(1017, 601);
            Receive_sale.TabIndex = 8;
            Receive_sale.Text = "ReceiveSale";
            Receive_sale.UseVisualStyleBackColor = true;
            // 
            // btn_Receive_sale
            // 
            btn_Receive_sale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Receive_sale.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Receive_sale.Depth = 0;
            btn_Receive_sale.HighEmphasis = true;
            btn_Receive_sale.Icon = null;
            btn_Receive_sale.Location = new Point(799, 9);
            btn_Receive_sale.Margin = new Padding(4, 6, 4, 6);
            btn_Receive_sale.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Receive_sale.Name = "btn_Receive_sale";
            btn_Receive_sale.NoAccentTextColor = Color.Empty;
            btn_Receive_sale.Size = new Size(79, 36);
            btn_Receive_sale.TabIndex = 24;
            btn_Receive_sale.Text = "Receive";
            btn_Receive_sale.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Receive_sale.UseAccentColor = false;
            btn_Receive_sale.UseVisualStyleBackColor = true;
            btn_Receive_sale.Click += btnShowReport_Click;
            // 
            // myshoereport
            // 
            myshoereport.AllowExternalDrop = true;
            myshoereport.CreationProperties = null;
            myshoereport.DefaultBackgroundColor = Color.White;
            myshoereport.Location = new Point(151, 53);
            myshoereport.Name = "myshoereport";
            myshoereport.Size = new Size(643, 539);
            myshoereport.TabIndex = 23;
            myshoereport.Visible = false;
            myshoereport.ZoomFactor = 1D;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CB_SALES
            // 
            CB_SALES.AutoResize = false;
            CB_SALES.BackColor = Color.FromArgb(255, 255, 255);
            CB_SALES.Depth = 0;
            CB_SALES.DrawMode = DrawMode.OwnerDrawVariable;
            CB_SALES.DropDownHeight = 174;
            CB_SALES.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_SALES.DropDownWidth = 121;
            CB_SALES.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CB_SALES.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CB_SALES.FormattingEnabled = true;
            CB_SALES.IntegralHeight = false;
            CB_SALES.ItemHeight = 43;
            CB_SALES.Location = new Point(800, 67);
            CB_SALES.MaxDropDownItems = 4;
            CB_SALES.MouseState = MaterialSkin.MouseState.OUT;
            CB_SALES.Name = "CB_SALES";
            CB_SALES.Size = new Size(151, 49);
            CB_SALES.StartIndex = 0;
            CB_SALES.TabIndex = 26;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 697);
            Controls.Add(ReceiveSale);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = ReceiveSale;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminDashBoard";
            Padding = new Padding(3, 58, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            ReceiveSale.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SaleDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Sale).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_QTY).EndInit();
            Receive_sale.ResumeLayout(false);
            Receive_sale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myshoereport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl ReceiveSale;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel Lbl_Product;
        private MaterialSkin.Controls.MaterialTextBox Txt_CName;
        private MaterialSkin.Controls.MaterialLabel Cust_Name;
        private CustomControls.RoundedButton AddNewProduct1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MaterialSkin.Controls.MaterialComboBox CB_Product;
        private MaterialSkin.Controls.MaterialLabel lblQty;
        private NumericUpDown n_QTY;
        private DataGridView dgv_SaleDetails;
        private DataGridView dgv_Sale;
        private MaterialSkin.Controls.MaterialButton AddProduct;
        private MaterialSkin.Controls.MaterialButton BTN_OK;
        private TabPage Receive_sale;
        private MaterialSkin.Controls.MaterialButton btnReceive;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btn_Receive_sale;
        private Microsoft.Web.WebView2.WinForms.WebView2 myshoereport;
        private MaterialSkin.Controls.MaterialComboBox CB_SALES;
    }
}