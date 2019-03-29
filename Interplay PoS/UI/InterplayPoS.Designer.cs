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
            this.tabMainFormInterplayPoS = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.tblLayout_Right_Sales = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayout_Items = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCatagory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelArticle = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new UI.CustomControls.InterplayPOSTextBox();
            this.tblLayout_Left_Sales = new System.Windows.Forms.TableLayoutPanel();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabPurchase = new System.Windows.Forms.TabPage();
            this.tabMainFormInterplayPoS.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tblLayout_Right_Sales.SuspendLayout();
            this.tblLayout_Items.SuspendLayout();
            this.tblLayout_Left_Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
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
            this.tabSales.Controls.Add(this.tblLayout_Right_Sales);
            this.tabSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSales.Location = new System.Drawing.Point(4, 44);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(926, 415);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // tblLayout_Right_Sales
            // 
            this.tblLayout_Right_Sales.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLayout_Right_Sales.ColumnCount = 2;
            this.tblLayout_Right_Sales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout_Right_Sales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayout_Right_Sales.Controls.Add(this.tblLayout_Items, 1, 0);
            this.tblLayout_Right_Sales.Controls.Add(this.tblLayout_Left_Sales, 0, 0);
            this.tblLayout_Right_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Right_Sales.Location = new System.Drawing.Point(3, 3);
            this.tblLayout_Right_Sales.Name = "tblLayout_Right_Sales";
            this.tblLayout_Right_Sales.RowCount = 1;
            this.tblLayout_Right_Sales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_Right_Sales.Size = new System.Drawing.Size(920, 409);
            this.tblLayout_Right_Sales.TabIndex = 0;
            // 
            // tblLayout_Items
            // 
            this.tblLayout_Items.ColumnCount = 1;
            this.tblLayout_Items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_Items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout_Items.Controls.Add(this.flowLayoutPanelCatagory, 0, 0);
            this.tblLayout_Items.Controls.Add(this.flowLayoutPanelProducts, 0, 2);
            this.tblLayout_Items.Controls.Add(this.flowLayoutPanelArticle, 0, 3);
            this.tblLayout_Items.Controls.Add(this.txtSearch, 0, 1);
            this.tblLayout_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Items.Location = new System.Drawing.Point(371, 4);
            this.tblLayout_Items.Name = "tblLayout_Items";
            this.tblLayout_Items.RowCount = 4;
            this.tblLayout_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Items.Size = new System.Drawing.Size(545, 401);
            this.tblLayout_Items.TabIndex = 0;
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
            // tblLayout_Left_Sales
            // 
            this.tblLayout_Left_Sales.ColumnCount = 1;
            this.tblLayout_Left_Sales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_Left_Sales.Controls.Add(this.dgCart, 0, 0);
            this.tblLayout_Left_Sales.Controls.Add(this.lblTotal, 0, 1);
            this.tblLayout_Left_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Left_Sales.Location = new System.Drawing.Point(4, 4);
            this.tblLayout_Left_Sales.Name = "tblLayout_Left_Sales";
            this.tblLayout_Left_Sales.RowCount = 2;
            this.tblLayout_Left_Sales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLayout_Left_Sales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayout_Left_Sales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout_Left_Sales.Size = new System.Drawing.Size(360, 401);
            this.tblLayout_Left_Sales.TabIndex = 1;
            // 
            // dgCart
            // 
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCart.Location = new System.Drawing.Point(3, 3);
            this.dgCart.Name = "dgCart";
            this.dgCart.Size = new System.Drawing.Size(354, 274);
            this.dgCart.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lblTotal.Size = new System.Drawing.Size(0, 57);
            this.lblTotal.TabIndex = 1;
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
            this.tblLayout_Right_Sales.ResumeLayout(false);
            this.tblLayout_Items.ResumeLayout(false);
            this.tblLayout_Items.PerformLayout();
            this.tblLayout_Left_Sales.ResumeLayout(false);
            this.tblLayout_Left_Sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMainFormInterplayPoS;
        private System.Windows.Forms.TabPage tabPurchase;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Right_Sales;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Items;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCatagory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelArticle;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Left_Sales;
        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.Label lblTotal;
        private InterplayPOSTextBox txtSearch;
    }
}

