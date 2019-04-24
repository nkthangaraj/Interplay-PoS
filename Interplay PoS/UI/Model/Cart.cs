using BL.Contracts.Catalogue;
using io.cloudloom.interplay.pos.Proxy.Contracts.Carts;
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
                existingItem.Update(count, existingItem);

            this.calculateNetAmount();
        }

        public void UpdateQuantity(string articleId, int quantity = 1)
        {
            Item existingItem = Items.Where(item => item.ReferenceArticleId == articleId).FirstOrDefault();

            existingItem.Update(quantity, existingItem);

            if (existingItem.Quantity == 0)
                this.RemoveItem(articleId);

            this.calculateNetAmount();
        }

        public void RemoveItem(string referenceId)
        {
            Items.RemoveAll(item => item.ReferenceArticleId == referenceId);
            this.calculateNetAmount();
        }

        public void ClearCart()
        {
            Items.Clear();
            this.calculateNetAmount();
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

        public void Update(int count, Item item)
        {
            item.Quantity = item.Quantity + count;
            item.Total = item.Quantity * 2;
        }
    }

}
