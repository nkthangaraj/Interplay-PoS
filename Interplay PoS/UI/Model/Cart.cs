using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    public class Cart
    {
        public Cart()
        {
            Items = new List<Item>();
        }

        public List<Item> Items { get; set; }
        public double NetAmount { get; set; }

        public void Add(SimpleArticle article, int count)
        {
            Items.Add(
                new Item
                {
                    Name = article.name,
                    Quantity = count,
                    //UnitPrice =Convert.ToDouble(article.properties.FirstOrDefault().unit)
                    UnitPrice = 2,
                    Total = count * 2
                });

            this.calculateNetAmount();
        }

        private void calculateNetAmount()
        {
            this.NetAmount = this.Items.Sum(item => item.Total);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Total { get; set; }
    }
}
