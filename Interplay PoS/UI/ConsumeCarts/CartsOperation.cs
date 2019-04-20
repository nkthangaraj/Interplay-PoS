using io.cloudloom.interplay.pos.Proxy.Contracts;
using io.cloudloom.interplay.pos.Proxy.Contracts.Carts;
using Proxy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ConsumeCarts
{
    public class CartsOperation
    {
        private CartsService service;
        public CartsOperation()
        {
            service = new CartsService();
            Cart = service.OpenCarts();
        }
        public RootObject Cart { get; set; }


        public RootObject AddToCart(string articleId)
        {
            RootObject cart = service.AddToCart(Cart.id, articleId);
            return cart;
        }

        public RootObject DeleteItemFromCart(string articleId)
        {
            RootObject cart = service.DeleteItemFromCart(Cart.id, articleId);
            return cart;
        }

        public RootObject CheckoutCartItems()
        {
            RootObject cart = service.CheckOutCartItems(Cart.id);
            return cart;            
        }


        public Proxy.Contracts.ActiveCarts.RootObject GetAllActiveCartsByUser()
        {
            Proxy.Contracts.ActiveCarts.RootObject cart = service.GetUserActiveCarts();
            return cart;
        }
    }
}
