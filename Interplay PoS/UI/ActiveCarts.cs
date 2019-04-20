using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CustomControls;

namespace UI
{
    public partial class ActiveCarts : Form
    {
        public delegate void SelectedActiveCart(Proxy.Contracts.ActiveCarts.Cart cart);

        public SelectedActiveCart ActiveCart;
        public ActiveCarts()
        {
            InitializeComponent();
        }


        public void CreateUserSelectionButtons(Proxy.Contracts.ActiveCarts.RootObject cartDetails)
        {
            foreach (var cart in cartDetails._embedded.carts)
            {
                InterPlayPOSAllCartsButton button = new InterPlayPOSAllCartsButton();
                button.Text = cart.id;
                button.Cart = cart;
                button.Click += User_Button_Click;
                button.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                activeCardsFlowLayoutPanel.Controls.Add(button);
            }
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            Proxy.Contracts.ActiveCarts.Cart cart = ((InterPlayPOSAllCartsButton)sender).Cart;
            ActiveCart(cart);
        }
    }
}
