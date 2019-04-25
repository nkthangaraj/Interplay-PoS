using Proxy.Contracts;
using Proxy.Contracts.Cart;
using System.Collections.Generic;

namespace Proxy.Services
{
   public class CartsService
    {
        private const string baseUrl = "https://dev.interplay.loomws.net/";
        private InterplayJSonServiceClient serviceClient;

        public CartsService(Credential credential)
        {
            this.serviceClient = new InterplayJSonServiceClient(credential);
        }

        public Cart OpenCart()
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Cart cart = serviceClient.Post<Cart>(string.Format("{0}{1}", baseUrl,"carts"),null);
            return cart;
        }


        public Cart AddItemsToCart(string cartId,Items items)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Cart cart = serviceClient.Post<Cart>(string.Format("{0}{1}", baseUrl, "carts/"+cartId+"/items"), items);
            return cart;
        }

        public Cart DeleteItemsFromCart(string cartId, Items items)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Cart cart = serviceClient.Delete<Cart>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/items/"+ items));
            return cart;
        }

        public Cart CheckOutCart(string cartId)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Cart cart = serviceClient.Put<Cart>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/checkout"),null);
            return cart;
        }

        public List<Cart> GetUserActiveCarts()
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            RootObject rootObject = serviceClient.Get<RootObject>(string.Format("{0}{1}", baseUrl, "carts/" + "all" + "/status?"+"status=OPEN"));
            return rootObject._embedded.carts;
        }

        public Cart AbandonActiveCart(string cartId)
        {
                serviceClient.BaseUri = baseUrl;
                string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
                serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
                Cart cart = serviceClient.Put<Cart>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/abandon"), null);
                return cart;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
