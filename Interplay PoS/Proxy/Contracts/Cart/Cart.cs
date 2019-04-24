using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Contracts.Cart
{
    public class Cart
    {
        public string id { get; set; }
        public string cartId { get; set; }
        public string userId { get; set; }
        public DateTime created { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public List<LineItem> lineItems { get; set; }
        public SubTotal2 subTotal { get; set; }
        public Links _links { get; set; }
    }
}
