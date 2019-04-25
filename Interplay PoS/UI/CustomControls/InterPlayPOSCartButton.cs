//using io.cloudloom.interplay.pos.Proxy.Contracts.Carts;
using BL.Contracts.Cart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CustomControls
{
    public class InterPlayPOSCartButton: InterPlayPOSButton
    {
        public InterPlayPOSCartButton()
        {
           
        }
        public Cart Cart { get; set; }
    }
}
