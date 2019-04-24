using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.Catalogue
{
    public class Links
    {
        public Self self { get; set; }
        public Catalog2 catalog { get; set; }
    }
}
