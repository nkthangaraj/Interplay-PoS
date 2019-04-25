using ProxyCartContract = Proxy.Contracts.Cart;
using BusinessCartContract = BL.Contracts.Cart;
using Proxy.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Proxy.Contracts;
using AutoMapper;

namespace BL
{
    public class CartBL
    {
        CartsService cartService;

        public CartBL(Credential credential)
        {
            cartService = new CartsService(credential);
        }

        public BusinessCartContract.Cart OpenCart()
        {
            ProxyCartContract.Cart cart =  this.cartService.OpenCart();
            BusinessCartContract.Cart businessCart = this.ConvertToBusinessCart(cart);
            return businessCart;
        }

        public BusinessCartContract.Cart AddItemsToCart(string cartId, BusinessCartContract.Items addItems)
        {
            ProxyCartContract.Items proxyItems = Mapper.Map<BusinessCartContract.Items, ProxyCartContract.Items>(addItems);
            ProxyCartContract.Cart cart = this.cartService.AddItemsToCart(cartId, proxyItems);
            BusinessCartContract.Cart businessCart = this.ConvertToBusinessCart(cart);
            return businessCart;
        }

        public BusinessCartContract.Cart DeleteItemsFromCart(string cartId, BusinessCartContract.Items deleteItems)
        {
            ProxyCartContract.Items proxyItems = Mapper.Map<BusinessCartContract.Items, ProxyCartContract.Items>(deleteItems);
            ProxyCartContract.Cart cart = this.cartService.DeleteItemsFromCart(cartId, proxyItems);
            BusinessCartContract.Cart businessCart = this.ConvertToBusinessCart(cart);
            return businessCart;
        }

        public BusinessCartContract.Cart CheckOutCart(string cartId)
        {
            ProxyCartContract.Cart proxyCart = this.cartService.CheckOutCart(cartId);
            BusinessCartContract.Cart cart = this.ConvertToBusinessCart(proxyCart);
            return cart;
        }

        public BusinessCartContract.Cart AbandonCart(string cartId)
        {
            ProxyCartContract.Cart proxyCart = this.cartService.AbandonActiveCart(cartId);
            BusinessCartContract.Cart cart = this.ConvertToBusinessCart(proxyCart);
            return cart;
        }

        public List<BusinessCartContract.Cart> GetActiveCartsByUser()
        {
            List<ProxyCartContract.Cart> proxyCarts = this.cartService.GetUserActiveCarts();
            List<BusinessCartContract.Cart> businessCarts = this.ConvertToBusinessCart(proxyCarts);
            return businessCarts;
        }

        #region Converters

        private BusinessCartContract.Cart ConvertToBusinessCart(ProxyCartContract.Cart proxyCart)
        {
            BusinessCartContract.Cart businessCart = Mapper.Map<ProxyCartContract.Cart, BusinessCartContract.Cart>(proxyCart);
            return businessCart;
        }

        private List<BusinessCartContract.Cart> ConvertToBusinessCart(List<ProxyCartContract.Cart> proxyCart)
        {
           List<BusinessCartContract.Cart> businessCart = Mapper.Map<List<ProxyCartContract.Cart>, List<BusinessCartContract.Cart>>(proxyCart);
           return businessCart;
        }

        private ProxyCartContract.Cart ConvertToProxyCart(BusinessCartContract.Cart businessCart)
        {
            ProxyCartContract.Cart proxyCart = Mapper.Map<BusinessCartContract.Cart, ProxyCartContract.Cart>(businessCart);
            return proxyCart;
        }

        #endregion
    }
}
