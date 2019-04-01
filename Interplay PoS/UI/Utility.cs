using System;
using System.Windows.Forms;
using UI.CustomControls;
using UI.Model;

namespace UI
{
    public static class Utility
    {
        public static void CreateCartDatagridView(DataGridView cartGrid, Cart cart)
        {
            cartGrid.Rows.Clear();

                int serialNumber = 1;
                foreach (Item item in cart.Items)
                {
                    cartGrid.Rows.Add(new object[]
                    {
                        item.ReferenceArticleId,
                        Convert.ToString(serialNumber),
                        item.ItemName,
                        Convert.ToString(item.Quantity),
                        Convert.ToString(item.UnitPrice),
                        Convert.ToString(item.Total)

                    });

                    serialNumber++;
                }
            }
        }
    }
