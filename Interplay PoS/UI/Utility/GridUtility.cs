using io.cloudloom.interplay.pos.Proxy.Contracts.Carts;
using System;
using System.Windows.Forms;
using UI.CustomControls;
using UI.Model;

namespace Utility
{
    public static class GridUtility
    {
        public static void CreateCartDatagridView(DataGridView cartGrid, RootObject cart)
        {
            cartGrid.Rows.Clear();

            foreach (var item in cart.lineItems)
            {
                cartGrid.Rows.Add(new object[]

                {
                    item.articleID,
                    item.name,
                    item.quantity//,
                    //item.unitPrice.amount,
                   // item.subTotal.amount
                });
            }
        }

        public static void ClearCartGrid(DataGridView cartGrid)
        {
            cartGrid.Rows.Clear();
        }
    }
}
