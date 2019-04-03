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
    public class InterplayJSonServiceClient : JsonServiceClient
    {
        public InterplayJSonServiceClient(Credential cre)
        {
            Credential credential = new Credential { UserName = cre.UserName, Password = cre.Password };
            this.SetCredentials(credential.UserName, credential.Password);
            CookieContainer container = new CookieContainer();
            this.CookieContainer = container;
        }

        public override TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
                TResponse response =  base.Get<TResponse>(relativeOrAbsoluteUrl);
                return response;
        }
    }
}
