using Proxy.Contracts;
using Proxy.Contracts.Cart;

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
            Cart catalogue = serviceClient.Post<Cart>(string.Format("{0}{1}", baseUrl,"carts"),null);
            return catalogue;
        }


        public Cart AddToCart(string cartId,string articleId, int quantity)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Items items = new Items() { articleId = articleId, quantity = quantity };
            Cart lineItems = serviceClient.Post<Cart>(string.Format("{0}{1}", baseUrl, "carts/"+cartId+"/items"), items);
            return lineItems;
        }

        public Cart DeleteItemFromCart(string cartId, string articleId)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Cart lineItems = serviceClient.Delete<Cart>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/items/"+ articleId));
            return lineItems;
        }

        public Cart CheckOutCartItems(string cartId)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);
            Cart lineItems = serviceClient.Put<Cart>(string.Format("{0}{1}", baseUrl, "carts/" + cartId + "/checkout"),null);
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
