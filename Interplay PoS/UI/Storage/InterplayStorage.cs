using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Model;

namespace UI.Storage
{
    public static class InterplayStorage
    {
        static InterplayStorage()
        {
            Cart = new Cart();
        }
        public static List<Catalog> Catalogues { get; set; }
        public static Catalog SelectedCatalog { get; set; }
        public static ProductEntry SelectedProductEntry { get; set; }
        public static SimpleArticle SelectedSimpleArticle { get; set; }
        public static Cart Cart { get; set; }
    }
}
