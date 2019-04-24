using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Contracts.Catalogue
{
    public class Catalogue
    {
        public string name { get; set; }
        public List<ProductEntry> productEntries { get; set; }
    }
}
