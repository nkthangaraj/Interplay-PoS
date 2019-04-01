using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using System.Collections.Generic;
using System.Linq;

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
            Item existingItem = Items.Where(item => item.ReferenceArticleId == article.referenceArticleId).FirstOrDefault();

            if (existingItem == null)
            {
                Items.Add(
                    new Item
                    {
                        ItemName = article.name,
                        ReferenceArticleId = article.referenceArticleId,
                        Quantity = count,
                        UnitPrice = 2,
                        Total = count * 2
                    });
            }

            else
                existingItem.Update(article, count, existingItem);

            this.calculateNetAmount();
        }

        public void RemoveItem(string referenceId)
        {
            Items.RemoveAll(item => item.ReferenceArticleId == referenceId);
        }

        private void calculateNetAmount()
        {
            this.NetAmount = this.Items.Sum(item => item.Total);
        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Total { get; set; }
        public string ReferenceArticleId { get; set; }

        public void Update(SimpleArticle article, int count, Item item)
        {
            item.Quantity = item.Quantity + count;
            item.Total = item.Quantity * 2;
        }
    }

}
