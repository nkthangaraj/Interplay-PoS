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

        // Maintain only one instance and keep use that to hold the UI event handlers, which is to update once cart created/ updated/ suspended/ checked the UI
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
        public event ActiveCartLoaded activeCartLoaded;
        public event NewCartCreated newCartCreated;

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

            // Open the cart while adding the first item to the cart
            if (CartInstance == null || CartInstance.id == null)
            {
                cart = cartBL.OpenCart();
                // dont use below mapper, its creating new objects, loosing the event handlers, so do it manually
                //_instance = this.ConvertToUICart(cart);
                UpdateUIContract(cart, _instance);
            }

            if (_instance.status == "OPEN" && _instance.type == "Cart")
            {
                cart = cartBL.AddItemsToCart(_instance.id, businessItem);
                // dont use below mapper, its creating new objects, loosing the event handlers, so do it manually
                //_instance = this.ConvertToUICart(cart);
                UpdateUIContract(cart, _instance);

                if (this.cartItemUpdated != null)
                    this.cartItemUpdated.Invoke(_instance);
            }
        }

        public void SuspendCart()
        {
            cartBL = new CartBL(
                new Credential { UserName = InterplayStorage.SelectedUser.UserName, Password = InterplayStorage.SelectedUser.Password });

            cartBL.AbandonCart(_instance.id);
            this.ClearCartData();

            if (this.cartSuspended != null)
                _instance.cartSuspended.Invoke();
        }

        public void CreateNewCart()
        {
            if (_instance != null)
            {
                if (_instance.newCartCreated != null)
                    _instance.newCartCreated.Invoke();
            }
        }

        public void CheckOutCart()
        {
            cartBL = new CartBL(new Credential { UserName = InterplayStorage.SelectedUser.UserName, Password = InterplayStorage.SelectedUser.Password});

            cartBL.CheckOutCart(_instance.id);
            this.ClearCartData();

            if(_instance != null)
            {
                if (_instance.newCartCreated != null)
                    _instance.newCartCreated.Invoke();
            }
        }

        public void LoadCartInstance(BusinessCartContract.Cart cart)
        {
            UpdateUIContract(cart, _instance);

            if (activeCartLoaded != null)
                activeCartLoaded.Invoke(_instance);
        }

        public void ClearCartData()
        {
            _instance.id = null;
            _instance.userId = null;
            _instance.created = DateTime.Now;
            _instance.status = null;
            _instance.type = null;
            _instance.cartId = null;
            _instance.lineItems = null;
            _instance.subTotal = null;
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
