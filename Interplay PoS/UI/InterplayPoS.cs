﻿using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI;
using UI.CustomControls;
using UI.Storage;
using Utility;

namespace io.cloudloom.interplay.pos.ui
{
    public partial class interplayMainForm : Form
    {
        private const int REMOVE_COLUMN_INDEX = 6;
        private const int ID_COLUMN = 0;

        private bool mouseUp = false;
        private const int holdButtonDuration = 2000;

        public interplayMainForm()
        {
            InitializeComponent();
            CreateCatalogueButtons();
        }

        private void CreateCatalogueButtons()
        {
            foreach (Catalog catalog in InterplayStorage.Catalogues)
            {
                InterPlayPOSCatalogueButton button = new InterPlayPOSCatalogueButton();
                button.catalogue = catalog;
                button.Text = catalog.name;
                button.Click += Catalogue_Button_Click;
                flowLayoutPanelCatagory.Controls.Add(button);
            }

            this.SetDefaultCatalogue(InterplayStorage.Catalogues.First());
        }

        private void SetDefaultCatalogue(Catalog catalog)
        {
            InterplayStorage.SetSelectedCatalog(catalog.name);
            this.CreateProductButtons();
        }

        private void Catalogue_Button_Click(object sender, EventArgs e)
        {
            InterplayStorage.SetSelectedCatalog(((InterPlayPOSCatalogueButton)sender).Text);
            this.FormatSelectedItem((Button)sender);
            this.CreateProductButtons();
        }

        private void FormatSelectedItem(Button button)
        {
            button.BackColor = Color.Green;
            button.ForeColor = Color.White;
            button.Font = new Font(button.Font, FontStyle.Bold);
        }

        private void CreateProductButtons()
        {
            this.PrepareUIForCreateButtons();
            List<ProductEntry> productEntries = InterplayStorage.GetProductEntries();
            this.CreateProductButtons(productEntries);
        }

        private void CreateProductButtons(List<ProductEntry> productEntries)
        {
            foreach (ProductEntry product in productEntries)
            {
                InterPlayPOSProductEntryButton button = new InterPlayPOSProductEntryButton();
                button.Text = product.name;
                button.productEntry = product;
                button.Click += Product_Button_Click;
                flowLayoutPanelProducts.Controls.Add(button);
            }
        }

        private void PrepareUIForCreateButtons()
        {
            flowLayoutPanelProducts.Controls.Clear();
            flowLayoutPanelArticle.Controls.Clear();
        }

        private void Product_Button_Click(object sender, EventArgs e)
        {
            InterplayStorage.SetSelectedProductEntry(((InterPlayPOSProductEntryButton)sender).productEntry);
            this.FormatSelectedItem((Button)sender);
            this.CreateArticlebuttons();
        }

        private void CreateArticlebuttons()
        {
            flowLayoutPanelArticle.Controls.Clear();

            foreach (SimpleArticle article in InterplayStorage.GetSimpleArticles())
            {
                InterplayPOSArticleButton button = new InterplayPOSArticleButton();
                button.Text = article.name;
                button.simpleArticle = article;
                button.MouseDown += Article_Mouse_Down;
                button.MouseUp += Article_Mouse_Up;
                flowLayoutPanelArticle.Controls.Add(button);
            }
        }

        private void Article_Mouse_Up(object sender, MouseEventArgs e)
        {
            mouseUp = true;
            this.FormatSelectedItem((Button)sender);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PrepareUIForCreateButtons();
            this.CreateProductButtons(InterplayStorage.GetProductEntries(txtSearch.Text));
        }

        private void Article_Mouse_Down(object sender, MouseEventArgs e)
        {
            InterplayStorage.SetSelectedSimpleArticle(((InterplayPOSArticleButton)sender).simpleArticle);

            mouseUp = false;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            while (e.Button == MouseButtons.Left && e.Clicks == 1 && (mouseUp == false && stopWatch.ElapsedMilliseconds < holdButtonDuration))
                Application.DoEvents();

            if (stopWatch.ElapsedMilliseconds < holdButtonDuration)
            {
                InterplayStorage.Cart.Add(InterplayStorage.SelectedSimpleArticle, 1);
            }

            else
            {
                Quantity quantityForm = new Quantity();
                quantityForm.ShowDialog();
            }

            GridUtility.CreateCartDatagridView(this.dgCart, InterplayStorage.Cart);
            UpdateNetAmountInUI();
        }

        private void btnTest_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp = true;
        }

        private void dgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == REMOVE_COLUMN_INDEX)
            {
                DataGridViewCell idColumn = (DataGridViewCell)dgCart.Rows[e.RowIndex].Cells[ID_COLUMN];

                if (idColumn != null)
                {
                    InterplayStorage.Cart.RemoveItem(Convert.ToString(idColumn.Value));
                    GridUtility.CreateCartDatagridView(this.dgCart, InterplayStorage.Cart);
                    UpdateNetAmountInUI();
                }
            }
        }

        private void UpdateNetAmountInUI()
        {
            this.btnTotal.Text = Convert.ToString(InterplayStorage.Cart.NetAmount);
            this.btnTax.Text = "0.0";
            this.btnNetTotal.Text = Convert.ToString(InterplayStorage.Cart.NetAmount);
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void interplayMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            GridUtility.ClearCartGrid(this.dgCart);
            InterplayStorage.Cart.ClearCart();
            this.UpdateNetAmountInUI();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dgCart.SelectedRows.Count > 0)
            {
                string selectedArticleId =Convert.ToString(this.dgCart.SelectedRows[0].Cells[0].Value);
                InterplayStorage.Cart.RemoveItem(selectedArticleId);
                GridUtility.CreateCartDatagridView(this.dgCart, InterplayStorage.Cart);
                this.UpdateNetAmountInUI();
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (this.dgCart.SelectedRows.Count > 0)
            {
                string selectedArticleId = Convert.ToString(this.dgCart.SelectedRows[0].Cells[0].Value);
                InterplayStorage.Cart.UpdateQuantity(selectedArticleId, -1);
                GridUtility.CreateCartDatagridView(this.dgCart, InterplayStorage.Cart);
                this.UpdateNetAmountInUI();
            }
        }

        private void bnnIncrease_Click(object sender, EventArgs e)
        {
            if (this.dgCart.SelectedRows.Count > 0)
            {
                string selectedArticleId = Convert.ToString(this.dgCart.SelectedRows[0].Cells[0].Value);
                InterplayStorage.Cart.UpdateQuantity(selectedArticleId, 1);
                GridUtility.CreateCartDatagridView(this.dgCart, InterplayStorage.Cart);
                this.UpdateNetAmountInUI();
            }
        }
    }
}
