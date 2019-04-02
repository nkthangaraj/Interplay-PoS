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
            //try
            //{
                TResponse response =  base.Get<TResponse>(relativeOrAbsoluteUrl);
                return response;
            //}

            //catch(Exception ex)
            //{
                //if (ex.GetStatus() == HttpStatusCode.Unauthorized)
                //{
                //    Credential credential = new Credential { UserName = "admin", Password = "admin" };
                //    this.SetCredentials(credential.UserName, credential.Password);
                //    CookieContainer container = new CookieContainer();
                //    this.CookieContainer = container;
                //    //TResponse response = base.Get<TResponse>(relativeOrAbsoluteUrl);
                //    TResponse response = this.Get<TResponse>(relativeOrAbsoluteUrl);
                //    return response;
                //}
                //else
                //    return default(TResponse);
                
            //}

        }
    }
}
