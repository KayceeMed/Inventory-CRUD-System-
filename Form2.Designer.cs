namespace Page_Login
{
    partial class lblInventoryList
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
            this.pnlInventoryList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblInventList = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.lblProID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.txtBuyingPrice = new System.Windows.Forms.TextBox();
            this.lblBuyingPrice = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblBahayKuboMart = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSmallAddNewItems = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.picbPlusIcon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbIconItem = new System.Windows.Forms.PictureBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLowStockItems = new System.Windows.Forms.Label();
            this.picBIconStock = new System.Windows.Forms.PictureBox();
            this.pnlInventoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.pnlSmallAddNewItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPlusIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbIconItem)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBIconStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInventoryList
            // 
            this.pnlInventoryList.BackColor = System.Drawing.Color.White;
            this.pnlInventoryList.Controls.Add(this.btnFilter);
            this.pnlInventoryList.Controls.Add(this.lblInventList);
            this.pnlInventoryList.Controls.Add(this.txtSearchBar);
            this.pnlInventoryList.Controls.Add(this.dataGridView1);
            this.pnlInventoryList.Location = new System.Drawing.Point(603, 94);
            this.pnlInventoryList.Name = "pnlInventoryList";
            this.pnlInventoryList.Size = new System.Drawing.Size(707, 422);
            this.pnlInventoryList.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmStock,
            this.clmBuyingPrice,
            this.clmSellingPrice,
            this.clmStatus,
            this.clmActions});
            this.dataGridView1.Location = new System.Drawing.Point(25, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 348);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID No.";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.Width = 125;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.Width = 125;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.MinimumWidth = 6;
            this.clmStock.Name = "clmStock";
            this.clmStock.Width = 125;
            // 
            // clmBuyingPrice
            // 
            this.clmBuyingPrice.HeaderText = "Buying Price";
            this.clmBuyingPrice.MinimumWidth = 6;
            this.clmBuyingPrice.Name = "clmBuyingPrice";
            this.clmBuyingPrice.Width = 125;
            // 
            // clmSellingPrice
            // 
            this.clmSellingPrice.HeaderText = "Selling Price";
            this.clmSellingPrice.MinimumWidth = 6;
            this.clmSellingPrice.Name = "clmSellingPrice";
            this.clmSellingPrice.Width = 125;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.MinimumWidth = 6;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Width = 125;
            // 
            // clmActions
            // 
            this.clmActions.HeaderText = "Actions";
            this.clmActions.MinimumWidth = 6;
            this.clmActions.Name = "clmActions";
            this.clmActions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmActions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmActions.Width = 125;
            // 
            // lblInventList
            // 
            this.lblInventList.AutoSize = true;
            this.lblInventList.BackColor = System.Drawing.Color.Transparent;
            this.lblInventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventList.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblInventList.Location = new System.Drawing.Point(25, 17);
            this.lblInventList.Name = "lblInventList";
            this.lblInventList.Size = new System.Drawing.Size(141, 25);
            this.lblInventList.TabIndex = 28;
            this.lblInventList.Text = "Inventory List";
            this.lblInventList.Click += new System.EventHandler(this.lblSL_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.Honeydew;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(172, 17);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(263, 22);
            this.txtSearchBar.TabIndex = 27;
            this.txtSearchBar.Text = "Search Item...";
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.BackColor = System.Drawing.Color.White;
            this.pnlAddItem.Controls.Add(this.cbCategory);
            this.pnlAddItem.Controls.Add(this.btnAddProduct);
            this.pnlAddItem.Controls.Add(this.txtSellingPrice);
            this.pnlAddItem.Controls.Add(this.lblSellingPrice);
            this.pnlAddItem.Controls.Add(this.txtBuyingPrice);
            this.pnlAddItem.Controls.Add(this.lblBuyingPrice);
            this.pnlAddItem.Controls.Add(this.lblCategory);
            this.pnlAddItem.Controls.Add(this.txtStockQuantity);
            this.pnlAddItem.Controls.Add(this.lblStockQuantity);
            this.pnlAddItem.Controls.Add(this.txtProductName);
            this.pnlAddItem.Controls.Add(this.lblProductName);
            this.pnlAddItem.Controls.Add(this.txtProductID);
            this.pnlAddItem.Controls.Add(this.lblProID);
            this.pnlAddItem.Location = new System.Drawing.Point(259, 18);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(338, 498);
            this.pnlAddItem.TabIndex = 24;
            this.pnlAddItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddItem_Paint);
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Location = new System.Drawing.Point(13, 100);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(173, 16);
            this.lblProID.TabIndex = 30;
            this.lblProID.Text = "Product ID (Control Number)";
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.Color.Honeydew;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(16, 118);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(296, 22);
            this.txtProductID.TabIndex = 31;
            this.txtProductID.Text = "e.g. 001";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Honeydew;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(16, 172);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(296, 22);
            this.txtProductName.TabIndex = 33;
            this.txtProductName.Text = "Enter Product Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(13, 154);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 32;
            this.lblProductName.Text = "Product Name";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BackColor = System.Drawing.Color.Honeydew;
            this.txtStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.Location = new System.Drawing.Point(16, 230);
            this.txtStockQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(137, 22);
            this.txtStockQuantity.TabIndex = 35;
            this.txtStockQuantity.Text = "0";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(13, 212);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(92, 16);
            this.lblStockQuantity.TabIndex = 34;
            this.lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(156, 212);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 36;
            this.lblCategory.Text = "Category";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.BackColor = System.Drawing.Color.Honeydew;
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(159, 287);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(153, 22);
            this.txtSellingPrice.TabIndex = 41;
            this.txtSellingPrice.Text = "0.00";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(156, 269);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(82, 16);
            this.lblSellingPrice.TabIndex = 40;
            this.lblSellingPrice.Text = "Selling Price";
            // 
            // txtBuyingPrice
            // 
            this.txtBuyingPrice.BackColor = System.Drawing.Color.Honeydew;
            this.txtBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyingPrice.Location = new System.Drawing.Point(16, 287);
            this.txtBuyingPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuyingPrice.Name = "txtBuyingPrice";
            this.txtBuyingPrice.Size = new System.Drawing.Size(137, 22);
            this.txtBuyingPrice.TabIndex = 39;
            this.txtBuyingPrice.Text = "0.00";
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.AutoSize = true;
            this.lblBuyingPrice.Location = new System.Drawing.Point(13, 269);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(82, 16);
            this.lblBuyingPrice.TabIndex = 38;
            this.lblBuyingPrice.Text = "Buying Price";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(38, 447);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(263, 40);
            this.btnAddProduct.TabIndex = 42;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Honeydew;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "hygiene",
            "food",
            "ingredients",
            "cleaner",
            "supplies",
            "drinks"});
            this.cbCategory.Location = new System.Drawing.Point(160, 228);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(153, 24);
            this.cbCategory.TabIndex = 29;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.OliveDrab;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(441, 17);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 25);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Page_Login.Properties.Resources.green_bg;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1329, 663);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.lblBahayKuboMart);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnArchive);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 536);
            this.panel1.TabIndex = 43;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Page_Login.Properties.Resources.bahay_kubo_icon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 16);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(70, 76);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 51;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.DimGray;
            this.lblDashboard.Location = new System.Drawing.Point(91, 61);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(90, 18);
            this.lblDashboard.TabIndex = 53;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblBahayKuboMart
            // 
            this.lblBahayKuboMart.AutoSize = true;
            this.lblBahayKuboMart.BackColor = System.Drawing.Color.Transparent;
            this.lblBahayKuboMart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBahayKuboMart.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblBahayKuboMart.Location = new System.Drawing.Point(90, 41);
            this.lblBahayKuboMart.Name = "lblBahayKuboMart";
            this.lblBahayKuboMart.Size = new System.Drawing.Size(153, 20);
            this.lblBahayKuboMart.TabIndex = 52;
            this.lblBahayKuboMart.Text = "Bahay Kubo Mart";
            this.lblBahayKuboMart.Click += new System.EventHandler(this.lblBahayKuboMart_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.ForeColor = System.Drawing.Color.DimGray;
            this.btnReport.Location = new System.Drawing.Point(15, 151);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(228, 40);
            this.btnReport.TabIndex = 54;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.SystemColors.Control;
            this.btnArchive.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btnArchive.Location = new System.Drawing.Point(14, 195);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(228, 40);
            this.btnArchive.TabIndex = 55;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(15, 110);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 40);
            this.btnDashboard.TabIndex = 56;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(15, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 40);
            this.button1.TabIndex = 57;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlSmallAddNewItems
            // 
            this.pnlSmallAddNewItems.Controls.Add(this.lblDescription);
            this.pnlSmallAddNewItems.Controls.Add(this.lblAddItem);
            this.pnlSmallAddNewItems.Controls.Add(this.picbPlusIcon);
            this.pnlSmallAddNewItems.Location = new System.Drawing.Point(259, 15);
            this.pnlSmallAddNewItems.Name = "pnlSmallAddNewItems";
            this.pnlSmallAddNewItems.Size = new System.Drawing.Size(338, 73);
            this.pnlSmallAddNewItems.TabIndex = 46;
            this.pnlSmallAddNewItems.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(52, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(206, 13);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Register a new stock entry into the system.";
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItem.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblAddItem.Location = new System.Drawing.Point(50, 15);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(146, 25);
            this.lblAddItem.TabIndex = 32;
            this.lblAddItem.Text = "Add New Item";
            // 
            // picbPlusIcon
            // 
            this.picbPlusIcon.Location = new System.Drawing.Point(12, 18);
            this.picbPlusIcon.Name = "picbPlusIcon";
            this.picbPlusIcon.Size = new System.Drawing.Size(32, 32);
            this.picbPlusIcon.TabIndex = 30;
            this.picbPlusIcon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lblTotalItems);
            this.panel3.Controls.Add(this.picbIconItem);
            this.panel3.Location = new System.Drawing.Point(762, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 73);
            this.panel3.TabIndex = 47;
            // 
            // picbIconItem
            // 
            this.picbIconItem.Location = new System.Drawing.Point(12, 21);
            this.picbIconItem.Name = "picbIconItem";
            this.picbIconItem.Size = new System.Drawing.Size(32, 32);
            this.picbIconItem.TabIndex = 30;
            this.picbIconItem.TabStop = false;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblTotalItems.Location = new System.Drawing.Point(50, 15);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(92, 18);
            this.lblTotalItems.TabIndex = 32;
            this.lblTotalItems.Text = "Total Items";
            this.lblTotalItems.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.lblLowStockItems);
            this.panel4.Controls.Add(this.picBIconStock);
            this.panel4.Location = new System.Drawing.Point(1039, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 73);
            this.panel4.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Honeydew;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 35);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 33;
            // 
            // lblLowStockItems
            // 
            this.lblLowStockItems.AutoSize = true;
            this.lblLowStockItems.BackColor = System.Drawing.Color.Transparent;
            this.lblLowStockItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockItems.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblLowStockItems.Location = new System.Drawing.Point(50, 15);
            this.lblLowStockItems.Name = "lblLowStockItems";
            this.lblLowStockItems.Size = new System.Drawing.Size(134, 18);
            this.lblLowStockItems.TabIndex = 32;
            this.lblLowStockItems.Text = "Low Stock Items";
            // 
            // picBIconStock
            // 
            this.picBIconStock.Location = new System.Drawing.Point(12, 21);
            this.picBIconStock.Name = "picBIconStock";
            this.picBIconStock.Size = new System.Drawing.Size(32, 32);
            this.picBIconStock.TabIndex = 30;
            this.picBIconStock.TabStop = false;
            // 
            // lblInventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1322, 530);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSmallAddNewItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.pnlInventoryList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "lblInventoryList";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.lblInventoryList_Load);
            this.pnlInventoryList.ResumeLayout(false);
            this.pnlInventoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.pnlSmallAddNewItems.ResumeLayout(false);
            this.pnlSmallAddNewItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPlusIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbIconItem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBIconStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInventoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewButtonColumn clmActions;
        private System.Windows.Forms.Label lblInventList;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox txtBuyingPrice;
        private System.Windows.Forms.Label lblBuyingPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblBahayKuboMart;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSmallAddNewItems;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.PictureBox picbPlusIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.PictureBox picbIconItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLowStockItems;
        private System.Windows.Forms.PictureBox picBIconStock;
    }
}