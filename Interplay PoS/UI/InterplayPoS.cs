using BL.Contracts.Catalogue;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI;
//using UI.ConsumeCarts;
using UI.CustomControls;
using UI.Model.Cart;
using UI.Storage;

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
            Cart.CartInstance.CreateNewCart();
            AttachEventsForCartChanges();
        }

        private void AttachEventsForCartChanges()
        {
            Cart.CartInstance.cartItemUpdated += Cart_cartItemUpdated;
            Cart.CartInstance.activeCartLoaded += CartInstance_activeCartLoaded;
            Cart.CartInstance.cartSuspended += CartInstance_cartSuspended;
            Cart.CartInstance.newCartCreated += CartInstance_newCartCreated;
        }

        private void CartInstance_newCartCreated()
        {
            this.CreateZeroValuedCartUI();
            this.PrepareUIForActiveCarts();
        }

        private void CartInstance_cartSuspended()
        {
            CreateZeroValuedCartUI();
        }

        private void CreateZeroValuedCartUI()
        {
            this.btnTotal.Text = "0.0";
            this.btnTax.Text = "0.0";
            this.btnNetTotal.Text = "0.0";
        }

        private void PrepareUIForCart(Cart cart)
        {
            if(cart.status == "OPEN")
            {
                this.PrepareUIForActiveCarts();
            }

            else
            {
                this.PrepareUIForClosedCarts();
            }
        }

        private void PrepareUIForClosedCarts()
        {
            btnRemove.Enabled = false;
            bnnIncrease.Enabled = false;
            btnDecrease.Enabled = false;
            btnRemove.Enabled = false;
            btnProceedToPay.Enabled = false;
        }

        private void PrepareUIForActiveCarts()
        {
            btnRemove.Enabled = true;
            bnnIncrease.Enabled = true;
            btnDecrease.Enabled = true;
            btnRemove.Enabled = true;
            btnProceedToPay.Enabled = true;
        }

        private void CartInstance_cartItemUpdated(Cart cart)
        {
            this.UpdateCartDetails(cart);
        }

        private void CartInstance_activeCartLoaded(Cart cart)
        {
            this.UpdateCartDetails(cart);
        }

        private void Cart_cartItemUpdated(Cart cart)
        {
            this.UpdateCartDetails(cart);
        }


        private void UpdateCartDetails(Cart cart)
        {
            this.btnTotal.Text = Convert.ToString(cart.subTotal.amount);
            this.btnTax.Text = "0.0";
            this.btnNetTotal.Text = Convert.ToString(cart.subTotal.amount);
        }

        private void Cart_newCartCreated(Cart cart)
        {
            //((InterplayPOSDataGridView)this.dgCart).cart = cart;
        }

        private void CreateCatalogueButtons()
        {
            foreach (Catalogue catalog in InterplayStorage.Catalogues)
            {
                InterPlayPOSCatalogueButton button = new InterPlayPOSCatalogueButton();
                button.catalogue = catalog;
                button.Text = catalog.name;
                button.Click += Catalogue_Button_Click;
                flowLayoutPanelCatagory.Controls.Add(button);
            }

            this.SetDefaultCatalogue(InterplayStorage.Catalogues.First());
        }

        private void SetDefaultCatalogue(Catalogue catalog)
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
                ((InterplayPOSDataGridView)this.dgCart).cart.UpdateItems(
                    new Items
                    {
                        articleId = InterplayStorage.SelectedSimpleArticle.referenceArticleId,
                        quantity = 1
                    });
            }

            else
            {
                Quantity quantityForm = new Quantity();
                quantityForm.ShowDialog();
            }
        }

        private void btnTest_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp = true;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Cart.CartInstance.lineItems.ForEach(
            //    item => Cart.CartInstance.UpdateItems(
            //    new Items { articleId = item.articleID, quantity = -item.quantity }));

            Cart.CartInstance.SuspendCart();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (this.dgCart.SelectedRows.Count > 0)
            {
                string selectedArticleId = Convert.ToString(this.dgCart.SelectedRows[0].Cells[0].Value);
                Cart.CartInstance.UpdateItems(new Items { articleId = selectedArticleId, quantity = -1 });
            }
        }

        private void bnnIncrease_Click(object sender, EventArgs e)
        {
            if (this.dgCart.SelectedRows.Count > 0)
            {
                string selectedArticleId = Convert.ToString(this.dgCart.SelectedRows[0].Cells[0].Value);
                Cart.CartInstance.UpdateItems(new Items { articleId = selectedArticleId, quantity = 1 });
            }
        }

        private void btnProceedToPay_Click(object sender, EventArgs e)
        {

        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            InterplayStorage.SelectedUser = null;
            this.Close();
            UserSelection usersForm = new UserSelection();
            usersForm.Show();
        }

        // ActiveCarts allCarts;
        private void butActiveCarts_Click(object sender, EventArgs e)
        {
            ActiveCarts activeCarts = new ActiveCarts();
            activeCarts.Show();
        }

        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            if (this.dgCart.SelectedRows.Count > 0)
            {
                string selectedArticleId = Convert.ToString(this.dgCart.SelectedRows[0].Cells[0].Value);
                int quantity = Convert.ToInt16(this.dgCart.SelectedRows[0].Cells[2].Value);

                Cart.CartInstance.UpdateItems(new Items { articleId = selectedArticleId, quantity = -quantity });
            }
        }
    }
}
