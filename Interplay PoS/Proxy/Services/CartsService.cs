using io.cloudloom.interplay.pos.Proxy.Services;
using io.cloudloom.interplay.pos.Proxy.Contracts.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proxy.Services
{
   public class CartsService
    {
        private const string baseUrl = "https://dev.interplay.loomws.net/";
        private InterplayJSonServiceClient serviceClient;

        public CartsService()
        {
            this.serviceClient = new InterplayJSonServiceClient("Carts");
        }

        public RootObject OpenCarts()
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            RootObject catalogue = serviceClient.Post<RootObject>(string.Format("{0}{1}", baseUrl,"carts"),null);
            return catalogue;
        }


        public RootObject AddToCart(string cartId,string articleId, int quantity=1)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Items items = new Items() { articleId = articleId, quantity = quantity };
            RootObject lineItems = serviceClient.Post<RootObject>(string.Format("{0}{1}", baseUrl, "carts/"+cartId+"/items"), items);
            return lineItems;
        }

        public RootObject DeleteItemFromCart(string cartId, string articleId)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            RootObject lineItems = serviceClient.Delete<RootObject>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/items/"+ articleId));
            return lineItems;
        }

        public RootObject CheckOutCartItems(string cartId)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            RootObject lineItems = serviceClient.Put<RootObject>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/checkout"),null);
            return lineItems;
        }

        public Proxy.Contracts.ActiveCarts.RootObject GetUserActiveCarts()
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Proxy.Contracts.ActiveCarts.RootObject lineItems = serviceClient.Get<Proxy.Contracts.ActiveCarts.RootObject>(string.Format("{0}{1}", baseUrl, "carts/" + "all" + "/status?"+"status=OPEN"));
            return lineItems;
        }


        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
