using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.Catalogue
{
    public class SimpleArticle
    {
        public string version { get; set; }
        public string name { get; set; }
        public string referenceArticleId { get; set; }
        public string mode { get; set; }
        public List<Property> properties { get; set; }
    }
}
