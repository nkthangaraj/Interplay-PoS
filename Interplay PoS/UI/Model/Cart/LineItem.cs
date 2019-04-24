using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model.Cart
{
    public class LineItem
    {
        public string name { get; set; }
        public string articleID { get; set; }
        public UnitPrice unitPrice { get; set; }
        public int quantity { get; set; }
        public SubTotal subTotal { get; set; }
    }
}
