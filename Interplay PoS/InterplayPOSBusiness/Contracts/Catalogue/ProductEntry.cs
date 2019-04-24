using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Contracts.Catalogue
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
}
