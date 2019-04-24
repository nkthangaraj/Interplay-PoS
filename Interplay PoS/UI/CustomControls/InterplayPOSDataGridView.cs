using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Model;
using UI.Model.Cart;

namespace UI.CustomControls
{
    public class InterplayPOSDataGridView : DataGridView
    {
        public Cart cart = Cart.CartInstance;

        public InterplayPOSDataGridView()
        {
            cart.cartItemUpdated += Cart_cartItemUpdated;
            cart.cartSuspended += Cart_cartSuspended;
        }

        private void Cart_cartSuspended()
        {
            this.ClearRows();
        }

        private void Cart_cartItemUpdated(Cart cart)
        {
            this.CreateRows(cart);
        }

        private void CreateRows(Cart cart)
        {
            this.ClearRows();

            foreach (LineItem item in cart.lineItems)
            {
                if (item.quantity > 0)
                {
                    this.Rows.Add(new object[]
                    {
                            item.articleID,
                            item.name,
                            Convert.ToString(item.quantity),
                            Convert.ToString(item.unitPrice.amount),
                            Convert.ToString(item.subTotal.amount)

                    });
                }
            }
        }

        private void ClearRows()
        {
            this.Rows.Clear();
        }
    }
}
