using System;
using System.Windows.Forms;
using UI.CustomControls;
using UI.Model;

namespace Utility
{
    public static class GridUtility
    {
        public static void CreateCartDatagridView(DataGridView cartGrid, Cart cart)
        {
            cartGrid.Rows.Clear();

            foreach (Item item in cart.Items)
            {
                cartGrid.Rows.Add(new object[]
                {
                        item.ReferenceArticleId,
                        item.ItemName,
                        Convert.ToString(item.Quantity),
                        Convert.ToString(item.UnitPrice),
                        Convert.ToString(item.Total)

                });

            }
        }

        public static void ClearCartGrid(DataGridView cartGrid)
        {
            cartGrid.Rows.Clear();
        }
    }
}
