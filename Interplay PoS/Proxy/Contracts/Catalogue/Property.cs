using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.Catalogue
{
    public class Property
    {
        public string version { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string unit { get; set; }
        public string type { get; set; }
    }
}
