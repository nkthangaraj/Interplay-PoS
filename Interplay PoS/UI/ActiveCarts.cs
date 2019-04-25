using BL;
using BL.Contracts.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proxy.Contracts;
using UI.Storage;
using UI.CustomControls;

namespace UI
{
    public partial class ActiveCarts : Form
    {
        public ActiveCarts()
        {
            InitializeComponent();
            CreateActiveCartsbuttons();
        }

        private void CreateActiveCartsbuttons()
        {
            CartBL cartBL = new CartBL(new Credential {UserName = InterplayStorage.SelectedUser.UserName, Password = InterplayStorage.SelectedUser.Password });
            List<Cart> carts = cartBL.GetActiveCartsByUser();

            foreach(Cart cart in carts)
            {
                InterPlayPOSCartButton button = new InterPlayPOSCartButton();
                button.Cart = cart;
                button.Text = cart.cartId;
                button.Click += Cart_Button_Click;
                this.flowLayoutPanelCarts.Controls.Add(button);
            }
        }

        private void Cart_Button_Click(object sender, EventArgs e)
        {
            Cart cart = ((InterPlayPOSCartButton)sender).Cart;
            UI.Model.Cart.Cart.CartInstance.LoadCartInstance(cart);
            this.Close();

        }
    }
}
