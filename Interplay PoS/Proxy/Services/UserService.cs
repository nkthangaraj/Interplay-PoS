using io.cloudloom.interplay.pos.Proxy.Contracts;
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
        private const string baseUrl = "http://localhost:8080/";
        private InterplayJSonServiceClient serviceClient;

        public UserService(Credential credential)
        {
            this.serviceClient = new InterplayJSonServiceClient(credential);
        }

       public  string GetProfile()
        {
            serviceClient.BaseUri = baseUrl;
            Profile profile = serviceClient.Get<Profile>(string.Format("{0}{1}", baseUrl, "profile"));
            return profile.ToJson();
        }

        public string GetProfileUsers()
        {
            serviceClient.BaseUri = baseUrl;
            Users profile = serviceClient.Get<Users>(string.Format("{0}{1}", baseUrl, "profile/users"));
            return profile.ToJson();
        }
    }
}
