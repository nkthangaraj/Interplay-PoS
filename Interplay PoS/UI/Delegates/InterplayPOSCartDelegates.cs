using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Model;
using UI.Model.Cart;

namespace UI.Delegats
{
    public delegate void CartItemUpdated(Cart cart);
    public delegate void CartSuspended();
    public delegate void NewCartCreated(Cart cart);
}
