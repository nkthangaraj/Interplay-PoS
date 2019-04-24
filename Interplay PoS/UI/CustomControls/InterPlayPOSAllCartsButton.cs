//using io.cloudloom.interplay.pos.Proxy.Contracts.Carts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.CustomControls
{
    public class InterPlayPOSAllCartsButton: InterPlayPOSButton
    {
        public InterPlayPOSAllCartsButton()
        {
            Height = 60;
            Width = 80;
            BackColor = Color.Blue;
            ForeColor = Color.White;
           
        }
        //public Proxy.Contracts.ActiveCarts.Cart Cart { get; set; }
    }
}
