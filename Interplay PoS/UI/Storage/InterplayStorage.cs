using Proxy.Contracts;
using Proxy.Services;
using System.Collections.Generic;
using System.Linq;
using UI.Model;
using BL;
using BL.Contracts.Catalogue;
using BL.Contracts.User;
using UI.Model.Cart;

namespace UI.Storage
{
    public static class InterplayStorage
    {
        static InterplayStorage()
        {
            FontFamily = "Leelawadee";     
        }

        public static string FontFamily { get; set; }
        private static List<Catalogue> _catalogues;
        public static List<Catalogue> Catalogues
        {
            get
            {
                if (_catalogues == null)
                {
                    CatalogueBL catalogueBL = new CatalogueBL(
                        new Credential { UserName = InterplayStorage.SelectedUser.UserName, Password = InterplayStorage.SelectedUser.Password });
                    _catalogues = catalogueBL.GetCatalogues();
                }
                return _catalogues;
            }
            set
            {
                _catalogues = value;
            }
        }
        public static Catalogue SelectedCatalog { get; private set; }
        public static ProductEntry SelectedProductEntry { get; private set; }
        public static SimpleArticle SelectedSimpleArticle { get; private set; }
        public static Credential Credential { get; private set; }
        public static Cart Cart { get; set; }
        public static Credential SelectedUser { get; set; }

        public static List<ProductEntry> GetProductEntries()
        {
            List<ProductEntry> productEntries = new List<ProductEntry>();

             Catalogue catalog = InterplayStorage.Catalogues
                .Where(catalogue => catalogue.name == InterplayStorage.SelectedCatalog.name).FirstOrDefault();

            if (catalog != null)
            {
                productEntries = catalog.productEntries;
            }

            return productEntries;
        }

        public static List<ProductEntry> GetProductEntries(string productFilter)
        {
            return GetProductEntries().Where(product => product.name.ToLower().Contains(productFilter.ToLower())).ToList();
        }

        public static List<SimpleArticle> GetSimpleArticles()
        {
            List<SimpleArticle> simpleArticles = new List<SimpleArticle>();

            Catalogue catalogue = InterplayStorage.Catalogues.Where(cat => cat.name == InterplayStorage.SelectedCatalog.name).FirstOrDefault();

            if (catalogue != null)
            {
                ProductEntry productEntry = catalogue.productEntries.Where(pe => pe.referenceProductId == InterplayStorage.SelectedProductEntry.referenceProductId).FirstOrDefault();
                if (productEntry != null && productEntry.articleEntries != null)
                {
                    foreach (ArticleEntry article in productEntry.articleEntries)
                    {
                        if (article.simpleArticles != null && article.simpleArticles.Count > 0)
                        {
                            simpleArticles.AddRange(article.simpleArticles);
                        }
                        else
                        {
                            simpleArticles.Add(new SimpleArticle
                            {
                                name = article.name,
                                referenceArticleId = article.referenceArticleId
                            });
                        }
                    }
                }
            }

            return simpleArticles;
        }

        public static void SetSelectedCatalog(string catalogName)
        {
            InterplayStorage.SelectedCatalog = InterplayStorage.Catalogues
                .Where(catalogue => catalogue.name == catalogName).FirstOrDefault();
        }

        public static void SetSelectedProductEntry(ProductEntry selectedProduct)
        {
            SelectedProductEntry = selectedProduct;

        }

        public static void SetSelectedSimpleArticle(SimpleArticle selectedArticle)
        {
            SelectedSimpleArticle = selectedArticle;
        }

        public static void SetCredentials(string userName, string password)
        {
            Credential = new Credential { UserName = userName, Password = password };
        }

        public static void ClearCart()
        {
           // InterplayStorage.Cart.ClearCart();
        }

    }
}
