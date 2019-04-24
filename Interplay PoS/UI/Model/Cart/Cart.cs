using AutoMapper;
using BL;
using Proxy.Contracts;
using System;
using System.Collections.Generic;
using UI.Delegats;
using UI.Storage;
using BusinessCartContract = BL.Contracts.Cart;
using UICartContract = UI.Model.Cart;

namespace UI.Model.Cart
{
    public class Cart
    {
        #region Singleton implementation

        private Cart() { }

        private static Cart _instance;

        public static Cart CartInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new Cart();
                return _instance;
            }
        }

        #endregion

        #region Cart Delegates

        public event CartItemUpdated cartItemUpdated;
        public event CartSuspended cartSuspended;

        #endregion

        #region BusinessLogicClasses

        private CartBL cartBL = null;

        #endregion

        public string id { get; set; }
        public string cartId { get; set; }
        public string userId { get; set; }
        public DateTime created { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public List<LineItem> lineItems { get; set; }
        public SubTotal2 subTotal { get; set; }
        public Links _links { get; set; }

        public void UpdateItems(Items item)
        {
            BusinessCartContract.Items businessItem = Mapper.Map<UICartContract.Items, BusinessCartContract.Items>(item);

            cartBL = new CartBL(new Credential { UserName = InterplayStorage.SelectedUser.UserName, Password = InterplayStorage.SelectedUser.Password });

            BusinessCartContract.Cart cart = null;

            if (CartInstance == null || CartInstance.id == null)
            {
                cart = cartBL.OpenCart();
                // dont use below mapper, its creating new objects, loosing the event handlers, so do it manually
                //_instance = this.ConvertToUICart(cart);
                this.UpdateUIContract(cart, _instance);
            }

            cart = cartBL.AddItemsToCart(_instance.id, businessItem);
            // dont use below mapper, its creating new objects, loosing the event handlers, so do it manually
            //_instance = this.ConvertToUICart(cart);
            this.UpdateUIContract(cart, _instance);

            if (this.cartItemUpdated != null)
                this.cartItemUpdated.Invoke(_instance);
        }

        public void SuspendCart()
        {
            cartBL = new CartBL(
                new Credential { UserName = InterplayStorage.SelectedUser.UserName, Password = InterplayStorage.SelectedUser.Password });
            
            if (this.cartSuspended != null)
                _instance.cartSuspended.Invoke();

        }

        #region Converters

        private BusinessCartContract.Cart ConvertToBusinessCart(UICartContract.Cart proxyCart)
        {
            BusinessCartContract.Cart businessCart = Mapper.Map<UICartContract.Cart, BusinessCartContract.Cart>(proxyCart);
            return businessCart;
        }

        private UICartContract.Cart ConvertToUICart(BusinessCartContract.Cart businessCart)
        {
            UICartContract.Cart proxyCart = Mapper.Map<BusinessCartContract.Cart, UICartContract.Cart>(businessCart);
            return proxyCart;
        }

        private void UpdateUIContract(BusinessCartContract.Cart businessCart, UICartContract.Cart proxyCart)
        {
            proxyCart.id = businessCart.id;
            proxyCart.userId = businessCart.userId;
            proxyCart.created = businessCart.created;
            proxyCart.status = businessCart.status;
            proxyCart.type = businessCart.type;
            proxyCart.cartId = businessCart.cartId;
            proxyCart.lineItems = new List<LineItem>();

            foreach(BusinessCartContract.LineItem line in businessCart.lineItems)
            {
                UICartContract.LineItem UILineItem = new LineItem()
                {
                    articleID = line.articleID,
                    name = line.name,
                    quantity = line.quantity,
                    subTotal = new SubTotal() { amount = line.subTotal.amount, currency = line.subTotal.currency },
                    unitPrice = new UnitPrice() { amount = line.unitPrice.amount, currency = line.unitPrice.currency }
                };

                proxyCart.lineItems.Add(UILineItem);
            }

            proxyCart.subTotal = new SubTotal2() { amount = businessCart.subTotal.amount, currency = businessCart.subTotal.currency };
        }

        #endregion

    }
}
