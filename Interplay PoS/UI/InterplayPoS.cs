using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UI;
using UI.CustomControls;
using UI.Storage;

namespace io.cloudloom.interplay.pos.ui
{
    public partial class interplayMainForm : Form
    {
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
        }

        private void Catalogue_Button_Click(object sender, EventArgs e)
        {
            InterplayStorage.SetSelectedCatalog(((InterPlayPOSCatalogueButton)sender).Text);

            this.CreateProductButtons();
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
                button.Click += article_button_click;
                flowLayoutPanelArticle.Controls.Add(button);
            }

        }

        private void article_button_click(object sender, EventArgs e)
        {
            InterplayStorage.SetSelectedSimpleArticle(((InterplayPOSArticleButton)sender).simpleArticle);

            Quantity quantityForm = new Quantity();
            quantityForm.ShowDialog();
            this.dgCart.DataSource = null;
            this.dgCart.Refresh();
            this.dgCart.DataSource = InterplayStorage.Cart.Items;
            this.lblTotal.Text = "  Total amount: " + InterplayStorage.Cart.NetAmount;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PrepareUIForCreateButtons();
            this.CreateProductButtons(InterplayStorage.GetProductEntries(txtSearch.Text));
        }
    }
}
