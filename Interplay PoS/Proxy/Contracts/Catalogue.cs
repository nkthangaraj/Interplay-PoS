using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue
{
    public class ProductEntry
    {
        public object version { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string referenceProductId { get; set; }
        public List<ArticleEntry> articleEntries { get; set; }
        public List<Property> properties { get; set; }
    }


    public class Property
    {
        public string version { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string unit { get; set; }
        public string type { get; set; }
    }

    public class SimpleArticle
    {
        public string version { get; set; }
        public string name { get; set; }
        public string referenceArticleId { get; set; }
        public string mode { get; set; }
        public List<Property> properties { get; set; }
    }

    public class ArticleEntry
    {
        public string version { get; set; }
        public string name { get; set; }
        public string referenceArticleId { get; set; }
        public List<SimpleArticle> simpleArticles { get; set; }

    }



    public class Self
    {
        public string href { get; set; }
    }

    public class Catalog2
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Catalog2 catalog { get; set; }
    }

    public class Catalog
    {
        public string name { get; set; }
        public List<ProductEntry> productEntries { get; set; }
        public Links _links { get; set; }
    }

    public class Embedded
    {
        public List<Catalog> catalogs { get; set; }
    }

    public class Self2
    {
        public string href { get; set; }
        public bool templated { get; set; }
    }

    public class Profile
    {
        public string href { get; set; }
    }

    public class Links2
    {
        public Self2 self { get; set; }
        public Profile profile { get; set; }
    }

    public class Page
    {
        public int size { get; set; }
        public int totalElements { get; set; }
        public int totalPages { get; set; }
        public int number { get; set; }
    }

    public class RootObject
    {
        public Embedded _embedded { get; set; }
        public Links2 _links { get; set; }
        public Page page { get; set; }
    }
}
