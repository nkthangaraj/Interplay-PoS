using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.cloudloom.interplay.pos.Proxy.Contracts.Carts
{
    public class UnitPrice
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class SubTotal
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class LineItem
    {
        public string name { get; set; }
        public string articleID { get; set; }
        public UnitPrice unitPrice { get; set; }
        public int quantity { get; set; }
        public SubTotal subTotal { get; set; }
    }

    public class SubTotal2
    {
        public int amount { get; set; }
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

    public class RootObject
    {
        public string id { get; set; }
        public string userId { get; set; }
        public DateTime created { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public List<LineItem> lineItems { get; set; }
        public SubTotal2 subTotal { get; set; }
        public Links _links { get; set; }
    }

    public class Items
    {        
        public string articleId { get; set; }
        public int quantity { get; set; }
    }

}
