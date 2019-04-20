using io.cloudloom.interplay.pos.Proxy.Contracts;
using io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace io.cloudloom.interplay.pos.Proxy.Services
{
    public class UserService
    {
        private const string baseUrl = "https://dev.interplay.loomws.net/";
        private InterplayJSonServiceClient serviceClient;

        public UserService()
        {
            this.serviceClient = new InterplayJSonServiceClient();
        }

        public UserService(Credential credential)
        {
            this.serviceClient = new InterplayJSonServiceClient(credential);
        }

        public  User GetProfile()
        {
            serviceClient.BaseUri = baseUrl;
            string userNamePassword = Base64Encode(serviceClient.UserName + ":" + serviceClient.Password);
            serviceClient.AddHeader("Authorization","Basic " +userNamePassword);
            
            User currentLoggedinUser = serviceClient.Get<User>(string.Format("{0}{1}", baseUrl, "me"));   
            return currentLoggedinUser;
        }

        public RootObject GetProfileUsers()
        {
            serviceClient.BaseUri = baseUrl;
            RootObject allUsers = serviceClient.Get<RootObject>(string.Format("{0}{1}", baseUrl, "users/all"));
            return allUsers;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
