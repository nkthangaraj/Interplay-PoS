using io.cloudloom.interplay.pos.Proxy.Services;
using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using ServiceStack;
using io.cloudloom.interplay.pos.Proxy.Contracts;

namespace Proxy.Services
{
    public class CatalogueService
    {
        private const string baseUrl = "http://localhost:8080/";
        private InterplayJSonServiceClient serviceClient;

        public CatalogueService(Credential credential)
        {
            this.serviceClient = new InterplayJSonServiceClient(credential);
        }

        public RootObject GetCatalogue()
        {
            serviceClient.BaseUri = baseUrl;
            RootObject catalogue = serviceClient.Get<RootObject>(string.Format("{0}{1}", baseUrl, "catalogs"));
            return catalogue;
        }
    }
}
