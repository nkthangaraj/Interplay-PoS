using io.cloudloom.interplay.pos.Proxy.Contracts;
using Proxy.Contracts;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Services
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

        public InterplayJSonServiceClient()
        {
            //Credential credential = new Credential { UserName = cre.UserName, Password = cre.Password };
            //this.SetCredentials(credential.UserName, credential.Password);
            CookieContainer container = new CookieContainer();
            this.CookieContainer = container;
        }

        public override TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
               TResponse response = base.Get<TResponse>(relativeOrAbsoluteUrl);
               return response;
        }       


        public override TResponse Post<TResponse>(string relativeOrAbsoluteUrl, object requestDto)
        {
            return base.Post<TResponse>(relativeOrAbsoluteUrl, requestDto);
        }

        public override TResponse Put<TResponse>(string relativeOrAbsoluteUrl, object requestDto)
        {
            return base.Put<TResponse>(relativeOrAbsoluteUrl, requestDto);
        }

        public override TResponse Send<TResponse>(object request)
        {
            return base.Send<TResponse>(request);
        }

        public override TResponse Delete<TResponse>(string relativeOrAbsoluteUrl)
        {
            return base.Delete<TResponse>(relativeOrAbsoluteUrl);
        }       
    }
}
