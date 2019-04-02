using UI.CustomControls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMainFormInterplayPoS = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.tblLayout_Sales = new System.Windows.Forms.TableLayoutPanel();
            this.right = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCatagory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelArticle = new System.Windows.Forms.FlowLayoutPanel();
            this.left = new System.Windows.Forms.TableLayoutPanel();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPurchase = new System.Windows.Forms.TabPage();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.downLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtSearch = new UI.CustomControls.InterplayPOSTextBox();
            this.tabMainFormInterplayPoS.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tblLayout_Sales.SuspendLayout();
            this.right.SuspendLayout();
            this.left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            this.downLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainFormInterplayPoS
            // 
            this.tabMainFormInterplayPoS.Controls.Add(this.tabSales);
            this.tabMainFormInterplayPoS.Controls.Add(this.tabPurchase);
            this.tabMainFormInterplayPoS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainFormInterplayPoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tblLayout_Sales.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
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
            this.right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.right.Controls.Add(this.flowLayoutPanelCatagory, 0, 0);
            this.right.Controls.Add(this.flowLayoutPanelProducts, 0, 2);
            this.right.Controls.Add(this.flowLayoutPanelArticle, 0, 3);
            this.right.Controls.Add(this.txtSearch, 0, 1);
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Location = new System.Drawing.Point(371, 4);
            this.right.Name = "right";
            this.right.RowCount = 4;
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.right.Size = new System.Drawing.Size(545, 401);
            this.right.TabIndex = 0;
            // 
            // flowLayoutPanelCatagory
            // 
            this.flowLayoutPanelCatagory.AutoScroll = true;
            this.flowLayoutPanelCatagory.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanelCatagory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCatagory.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelCatagory.Name = "flowLayoutPanelCatagory";
            this.flowLayoutPanelCatagory.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelCatagory.Size = new System.Drawing.Size(539, 74);
            this.flowLayoutPanelCatagory.TabIndex = 0;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanelProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(3, 123);
            this.flowLayoutPanelProducts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(539, 187);
            this.flowLayoutPanelProducts.TabIndex = 1;
            // 
            // flowLayoutPanelArticle
            // 
            this.flowLayoutPanelArticle.AutoScroll = true;
            this.flowLayoutPanelArticle.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanelArticle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelArticle.Location = new System.Drawing.Point(3, 330);
            this.flowLayoutPanelArticle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowLayoutPanelArticle.Name = "flowLayoutPanelArticle";
            this.flowLayoutPanelArticle.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelArticle.Size = new System.Drawing.Size(539, 68);
            this.flowLayoutPanelArticle.TabIndex = 2;
            // 
            // left
            // 
            this.left.ColumnCount = 1;
            this.left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.left.Controls.Add(this.dgCart, 0, 0);
            this.left.Controls.Add(this.downLeft, 0, 1);
            this.left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left.Location = new System.Drawing.Point(4, 4);
            this.left.Name = "left";
            this.left.RowCount = 2;
            this.left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.left.Size = new System.Drawing.Size(360, 401);
            this.left.TabIndex = 1;
            // 
            // dgCart
            // 
            this.dgCart.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            this.dgCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCart.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SNo,
            this.ItemName,
            this.Quantity,
            this.UnitPrice,
            this.Total,
            this.Remove});
            this.dgCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCart.EnableHeadersVisualStyles = false;
            this.dgCart.Location = new System.Drawing.Point(3, 3);
            this.dgCart.Name = "dgCart";
            this.dgCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCart.RowHeadersVisible = false;
            this.dgCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCart.Size = new System.Drawing.Size(354, 314);
            this.dgCart.TabIndex = 2;
            this.dgCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCart_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SNo
            // 
            this.SNo.HeaderText = "S No";
            this.SNo.Name = "SNo";
            this.SNo.Width = 65;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Description";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 218;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 65;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 65;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 65;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Image = global::UI.Properties.Resources.delete16c16;
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.Width = 45;
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
            // downLeft
            // 
            this.downLeft.BackColor = System.Drawing.Color.GhostWhite;
            this.downLeft.ColumnCount = 2;
            this.downLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.downLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.downLeft.Controls.Add(this.lblTotal, 0, 0);
            this.downLeft.Controls.Add(this.lblTax, 0, 1);
            this.downLeft.Controls.Add(this.lblNetAmount, 0, 2);
            this.downLeft.Controls.Add(this.btnPay, 1, 2);
            this.downLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downLeft.Location = new System.Drawing.Point(9, 290);
            this.downLeft.Name = "downLeft";
            this.downLeft.RowCount = 3;
            this.downLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.downLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.downLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.downLeft.Size = new System.Drawing.Size(323, 108);
            this.downLeft.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 5);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(3, 35);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(34, 15);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax:";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.Location = new System.Drawing.Point(3, 70);
            this.lblNetAmount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(85, 15);
            this.lblNetAmount.TabIndex = 2;
            this.lblNetAmount.Text = "Net Amount:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Green;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(170, 73);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 32);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Proceed to Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 95);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 31);
            this.txtSearch.TabIndex = 3;
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
            this.tabMainFormInterplayPoS.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tblLayout_Sales.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            this.downLeft.ResumeLayout(false);
            this.downLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMainFormInterplayPoS;
        private System.Windows.Forms.TabPage tabPurchase;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Sales;
        private System.Windows.Forms.TableLayoutPanel right;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCatagory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelArticle;
        private InterplayPOSTextBox txtSearch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel left;
        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.TableLayoutPanel downLeft;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Button btnPay;
    }
}

