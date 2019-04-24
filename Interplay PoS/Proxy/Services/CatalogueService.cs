using Proxy.Contracts.Catalogue;
using Proxy.Contracts;
using System.Collections.Generic;

namespace Proxy.Services
{
    public class CatalogueService
    {
        private const string baseUrl = "https://dev.interplay.loomws.net/";
        private InterplayJSonServiceClient serviceClient;

        public CatalogueService(Credential credential)
        {
            this.serviceClient = new InterplayJSonServiceClient(credential);
        }

        public List<Catalogue> GetCatalogue()
        {
            serviceClient.BaseUri = baseUrl;
            RootObject catalogue = serviceClient.Get<RootObject>(string.Format("{0}{1}", baseUrl, "catalogs"));
            return catalogue._embedded.catalogs;
        }
    }
}
