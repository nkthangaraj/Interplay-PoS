using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplayService
{
    public class CatalogeService
    {
        private const string baseUrl = "http://localhost:8080/";
        private InterplayJSonServiceClient serviceClient;

        public CatalogeService()
        {
            this.serviceClient = new InterplayJSonServiceClient(new ConsoleAuthGetters());
        }

        public string GetCataloge()
        {
            serviceClient.BaseUri = baseUrl;
            InterplayService.Contracts.Cataloge.RootObject profile = serviceClient.Get<InterplayService.Contracts.Cataloge.RootObject>(string.Format("{0}{1}", baseUrl, "catalogs"));
            return profile.ToJson();
        }
    }
}
