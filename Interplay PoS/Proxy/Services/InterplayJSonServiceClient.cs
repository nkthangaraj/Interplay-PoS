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
        ICredentialGetter credentialGetter;

        public InterplayJSonServiceClient(ICredentialGetter credentialGetter)
        {
            this.credentialGetter = credentialGetter;
        }

        public override TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
            try
            {
                TResponse response =  base.Get<TResponse>(relativeOrAbsoluteUrl);
                return response;
            }

            catch(Exception ex)
            {
                if (ex.GetStatus() == HttpStatusCode.Unauthorized)
                {
                    Credential credential = this.credentialGetter.GetCredentials();
                    this.SetCredentials(credential.UserName, credential.Password);
                    CookieContainer container = new CookieContainer();
                    this.CookieContainer = container;
                    //TResponse response = base.Get<TResponse>(relativeOrAbsoluteUrl);
                    TResponse response = this.Get<TResponse>(relativeOrAbsoluteUrl);
                    return response;
                }
                else
                    return default(TResponse);
            }

        }
    }
}
