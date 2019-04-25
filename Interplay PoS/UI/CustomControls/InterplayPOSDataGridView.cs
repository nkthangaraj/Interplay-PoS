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

        public InterplayPOSDataGridView():base()
        {
            cart.cartItemUpdated += Cart_cartItemUpdated;
            cart.cartSuspended += Cart_cartSuspended;
            cart.activeCartLoaded += Cart_activeCartLoaded;
            cart.newCartCreated += Cart_newCartCreated;
        }

        private void Cart_newCartCreated()
        {
            this.ClearRows();
        }

        private void Cart_activeCartLoaded(Cart cart)
        {
            this.CreateCartRows(cart);
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
            this.CreateCartRows(cart);
        }

        private void CreateCartRows(Cart cart)
        {
            this.CreateColumns();
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

        private void CreateColumns()
        {
            if(this.Columns.Count == 0)
            {

                DataGridViewTextBoxColumn Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Total = new System.Windows.Forms.DataGridViewTextBoxColumn();

                Id.HeaderText = "Id";
                Id.Name = "Id";
                Id.Visible = false;
                // 
                // ItemName
                // 
                ItemName.HeaderText = "Description";
                ItemName.Name = "ItemName";
                ItemName.Width = 240;
                // 
                // Quantity
                // 
                Quantity.HeaderText = "Qty";
                Quantity.Name = "Quantity";
                Quantity.Width = 50;
                // 
                // UnitPrice
                // 
                UnitPrice.HeaderText = "Unit";
                UnitPrice.Name = "UnitPrice";
                UnitPrice.Width = 50;
                // 
                // Total
                // 
                Total.HeaderText = "Total";
                Total.Name = "Total";
                Total.Width = 50;

                this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                Id,
                ItemName,
                Quantity,
                UnitPrice,
                Total});
            }
        }
    }
}
