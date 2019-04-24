using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.Catalogue
{
    public class Catalogue
    {
        public string name { get; set; }
        public List<ProductEntry> productEntries { get; set; }
        public Links _links { get; set; }
    }
}
