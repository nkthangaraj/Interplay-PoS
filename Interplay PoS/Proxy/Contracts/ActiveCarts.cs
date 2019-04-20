

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.ActiveCarts
{
    public class UnitPrice
    {
        public double amount { get; set; }
        public string currency { get; set; }
    }

    public class SubTotal
    {
        public double amount { get; set; }
        public string currency { get; set; }
    }

    public class LineItem
    {
        public string id { get; set; }
        public DateTime created { get; set; }
        public string createdBy { get; set; }
        public DateTime modified { get; set; }
        public string lastModifiedBy { get; set; }
        public string name { get; set; }
        public string articleID { get; set; }
        public UnitPrice unitPrice { get; set; }
        public int quantity { get; set; }
        public SubTotal subTotal { get; set; }
    }

    public class SubTotal2
    {
        public double amount { get; set; }
        public string currency { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class Cart
    {
        public string id { get; set; }
        public DateTime created { get; set; }
        public string createdBy { get; set; }
        public DateTime modified { get; set; }
        public string lastModifiedBy { get; set; }
        public string userId { get; set; }
        public DateTime createdAt { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public List<LineItem> lineItems { get; set; }
        public SubTotal2 subTotal { get; set; }
        public Links _links { get; set; }
    }

    public class Embedded
    {
        public List<Cart> carts { get; set; }
    }

    public class Self2
    {
        public string href { get; set; }
    }

    public class Links2
    {
        public Self2 self { get; set; }
    }

    public class RootObject
    {
        public Embedded _embedded { get; set; }
        public Links2 _links { get; set; }
    }
}
