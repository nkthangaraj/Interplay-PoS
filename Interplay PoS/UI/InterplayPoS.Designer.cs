using UI.CustomControls;
using UI.Storage;

namespace io.cloudloom.interplay.pos.ui
{
    partial class interplayMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interplayMainForm));
            this.tabMainFormInterplayPoS = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.tblLayout_Sales = new System.Windows.Forms.TableLayoutPanel();
            this.right = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCatagory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelArticle = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.butClear = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.TableLayoutPanel();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProceedToPay = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNetTotal = new System.Windows.Forms.Button();
            this.bnnIncrease = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabPurchase = new System.Windows.Forms.TabPage();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new UI.CustomControls.InterplayPOSTextBox();
            this.tabMainFormInterplayPoS.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tblLayout_Sales.SuspendLayout();
            this.right.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainFormInterplayPoS
            // 
            this.tabMainFormInterplayPoS.Controls.Add(this.tabSales);
            this.tabMainFormInterplayPoS.Controls.Add(this.tabPurchase);
            this.tabMainFormInterplayPoS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainFormInterplayPoS.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainFormInterplayPoS.ItemSize = new System.Drawing.Size(150, 40);
            this.tabMainFormInterplayPoS.Location = new System.Drawing.Point(0, 0);
            this.tabMainFormInterplayPoS.Name = "tabMainFormInterplayPoS";
            this.tabMainFormInterplayPoS.SelectedIndex = 0;
            this.tabMainFormInterplayPoS.Size = new System.Drawing.Size(934, 463);
            this.tabMainFormInterplayPoS.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMainFormInterplayPoS.TabIndex = 1;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.tblLayout_Sales);
            this.tabSales.Font = new System.Drawing.Font("Leelawadee", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSales.Location = new System.Drawing.Point(4, 44);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(926, 415);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // tblLayout_Sales
            // 
            this.tblLayout_Sales.ColumnCount = 2;
            this.tblLayout_Sales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout_Sales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayout_Sales.Controls.Add(this.right, 1, 0);
            this.tblLayout_Sales.Controls.Add(this.left, 0, 0);
            this.tblLayout_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Sales.Location = new System.Drawing.Point(3, 3);
            this.tblLayout_Sales.Name = "tblLayout_Sales";
            this.tblLayout_Sales.RowCount = 1;
            this.tblLayout_Sales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_Sales.Size = new System.Drawing.Size(920, 409);
            this.tblLayout_Sales.TabIndex = 0;
            // 
            // right
            // 
            this.right.ColumnCount = 1;
            this.right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.right.Controls.Add(this.flowLayoutPanelCatagory, 0, 1);
            this.right.Controls.Add(this.flowLayoutPanelProducts, 0, 2);
            this.right.Controls.Add(this.flowLayoutPanelArticle, 0, 3);
            this.right.Controls.Add(this.panelSearch, 0, 0);
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Location = new System.Drawing.Point(371, 3);
            this.right.Name = "right";
            this.right.RowCount = 4;
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19757F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9561F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.89024F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9561F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.right.Size = new System.Drawing.Size(546, 403);
            this.right.TabIndex = 0;
            // 
            // flowLayoutPanelCatagory
            // 
            this.flowLayoutPanelCatagory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCatagory.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanelCatagory.Name = "flowLayoutPanelCatagory";
            this.flowLayoutPanelCatagory.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelCatagory.Size = new System.Drawing.Size(540, 74);
            this.flowLayoutPanelCatagory.TabIndex = 0;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(3, 124);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(540, 195);
            this.flowLayoutPanelProducts.TabIndex = 1;
            // 
            // flowLayoutPanelArticle
            // 
            this.flowLayoutPanelArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelArticle.Location = new System.Drawing.Point(3, 325);
            this.flowLayoutPanelArticle.Name = "flowLayoutPanelArticle";
            this.flowLayoutPanelArticle.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelArticle.Size = new System.Drawing.Size(540, 75);
            this.flowLayoutPanelArticle.TabIndex = 2;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.butClear);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(540, 35);
            this.panelSearch.TabIndex = 3;
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.LimeGreen;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(216, 6);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 26);
            this.butClear.TabIndex = 1;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // left
            // 
            this.left.ColumnCount = 1;
            this.left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.left.Controls.Add(this.dgCart, 0, 0);
            this.left.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left.Location = new System.Drawing.Point(3, 3);
            this.left.Name = "left";
            this.left.RowCount = 2;
            this.left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.left.Size = new System.Drawing.Size(362, 403);
            this.left.TabIndex = 1;
            // 
            // dgCart
            // 
            this.dgCart.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleGreen;
            this.dgCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgCart.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Leelawadee", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgCart.ColumnHeadersHeight = 40;
            this.dgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemName,
            this.Quantity,
            this.UnitPrice,
            this.Total});
            this.dgCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCart.EnableHeadersVisualStyles = false;
            this.dgCart.Location = new System.Drawing.Point(3, 3);
            this.dgCart.Name = "dgCart";
            this.dgCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Leelawadee", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgCart.RowHeadersVisible = false;
            this.dgCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCart.RowTemplate.Height = 40;
            this.dgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCart.Size = new System.Drawing.Size(356, 276);
            this.dgCart.TabIndex = 2;
            this.dgCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCart_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblNetTotal, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTax, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProceedToPay, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDecrease, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNetTotal, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.bnnIncrease, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTax, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTotal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 115);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.Location = new System.Drawing.Point(287, 46);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(56, 14);
            this.lblNetTotal.TabIndex = 5;
            this.lblNetTotal.Text = "Net Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(216, 46);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 14);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(145, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 14);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // btnProceedToPay
            // 
            this.btnProceedToPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProceedToPay.FlatAppearance.BorderSize = 0;
            this.btnProceedToPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedToPay.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedToPay.ForeColor = System.Drawing.Color.White;
            this.btnProceedToPay.Location = new System.Drawing.Point(287, 3);
            this.btnProceedToPay.Name = "btnProceedToPay";
            this.btnProceedToPay.Size = new System.Drawing.Size(66, 40);
            this.btnProceedToPay.TabIndex = 3;
            this.btnProceedToPay.Text = "Pay";
            this.btnProceedToPay.UseVisualStyleBackColor = false;
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDecrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrease.BackgroundImage")));
            this.btnDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecrease.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Location = new System.Drawing.Point(74, 3);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(61, 40);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(216, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnNetTotal
            // 
            this.btnNetTotal.BackColor = System.Drawing.Color.Silver;
            this.btnNetTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNetTotal.FlatAppearance.BorderSize = 0;
            this.btnNetTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetTotal.Font = new System.Drawing.Font("Leelawadee", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNetTotal.Location = new System.Drawing.Point(287, 72);
            this.btnNetTotal.Name = "btnNetTotal";
            this.btnNetTotal.Size = new System.Drawing.Size(66, 40);
            this.btnNetTotal.TabIndex = 9;
            this.btnNetTotal.Text = "0.0";
            this.btnNetTotal.UseVisualStyleBackColor = false;
            // 
            // bnnIncrease
            // 
            this.bnnIncrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnnIncrease.BackgroundImage")));
            this.bnnIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnnIncrease.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bnnIncrease.FlatAppearance.BorderSize = 0;
            this.bnnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnnIncrease.Location = new System.Drawing.Point(145, 3);
            this.bnnIncrease.Name = "bnnIncrease";
            this.bnnIncrease.Size = new System.Drawing.Size(61, 40);
            this.bnnIncrease.TabIndex = 0;
            this.bnnIncrease.UseVisualStyleBackColor = true;
            this.bnnIncrease.Click += new System.EventHandler(this.bnnIncrease_Click);
            // 
            // btnTax
            // 
            this.btnTax.BackColor = System.Drawing.Color.Silver;
            this.btnTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTax.FlatAppearance.BorderSize = 0;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTax.Font = new System.Drawing.Font("Leelawadee", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTax.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTax.Location = new System.Drawing.Point(216, 72);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(65, 40);
            this.btnTax.TabIndex = 8;
            this.btnTax.Text = "0.0";
            this.btnTax.UseVisualStyleBackColor = false;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Silver;
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Leelawadee", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTotal.Location = new System.Drawing.Point(145, 72);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(65, 40);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "0.0";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(3, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 40);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tabPurchase
            // 
            this.tabPurchase.Location = new System.Drawing.Point(4, 44);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchase.Size = new System.Drawing.Size(926, 415);
            this.tabPurchase.TabIndex = 1;
            this.tabPurchase.Text = "Purchase";
            this.tabPurchase.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::UI.Properties.Resources.delete16c16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 45;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Description";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 240;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 50;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // interplayMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 463);
            this.Controls.Add(this.tabMainFormInterplayPoS);
            this.Name = "interplayMainForm";
            this.ShowIcon = false;
            this.Text = "InterplayPoS";
            this.Load += new System.EventHandler(this.interplayMainForm_Load);
            this.tabMainFormInterplayPoS.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tblLayout_Sales.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMainFormInterplayPoS;
        private System.Windows.Forms.TabPage tabPurchase;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Sales;
        private System.Windows.Forms.TableLayoutPanel right;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel left;
        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCatagory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelArticle;
        private System.Windows.Forms.Panel panelSearch;
        private InterplayPOSTextBox txtSearch;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button bnnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProceedToPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnNetTotal;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

