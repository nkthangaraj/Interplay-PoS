using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.Catalogue
{
    public class RootObject
    {
        public Embedded _embedded { get; set; }
        public Links2 _links { get; set; }
        public Page page { get; set; }
    }
}
