using Proxy.Contracts;
using Proxy.Contracts.User;
using System.Collections.Generic;

namespace Proxy.Services
{
    public class UserService
    {
        private const string baseUrl = "https://dev.interplay.loomws.net/";
        private InterplayJSonServiceClient serviceClient;

        //public UserService()
        //{
        //    this.serviceClient = new InterplayJSonServiceClient();
        //}

        public UserService(Credential credential)
        {
            this.serviceClient = new InterplayJSonServiceClient(credential);
        }

        public User GetProfile(Credential credential)
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(credential.UserName + ":" + credential.Password);
            serviceClient.AddHeader("Authorization", "Basic " + userNamePassword);

            User currentLoggedinUser = serviceClient.Get<User>(string.Format("{0}{1}", baseUrl, "me"));
            return currentLoggedinUser;
        }

        public List<User> GetAllUsers()
        {
            serviceClient.BaseUri = baseUrl;
            RootObject root = serviceClient.Get<RootObject>(string.Format("{0}{1}", baseUrl, "users/all"));
            return root._embedded.users;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
