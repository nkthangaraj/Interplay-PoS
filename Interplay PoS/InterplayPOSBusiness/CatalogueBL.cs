using System.Collections.Generic;
using Proxy.Services;
using ProxyCatalogueContract = Proxy.Contracts.Catalogue;
using BusinessCatalogueContract = BL.Contracts.Catalogue;
using Proxy.Contracts;
using AutoMapper;

namespace BL
{
    public class CatalogueBL
    {
        CatalogueService service;

        public CatalogueBL(Credential credential)
        {
            this.service = new CatalogueService(credential);
        }

        public List<BusinessCatalogueContract.Catalogue> GetCatalogues()
        {
            List<ProxyCatalogueContract.Catalogue> proxyCatalogues = this.service.GetCatalogue();
            List<BusinessCatalogueContract.Catalogue> businessCatalogues = this.ConvertToBusiness(proxyCatalogues);
            return businessCatalogues;
        }

        #region Converters

        private List<BusinessCatalogueContract.Catalogue> ConvertToBusiness(
           List<ProxyCatalogueContract.Catalogue> catalogues)
        {
            List<BusinessCatalogueContract.Catalogue> businessCatalogues = new List<BusinessCatalogueContract.Catalogue>();

            businessCatalogues = Mapper.Map<List<ProxyCatalogueContract.Catalogue>,List<BusinessCatalogueContract.Catalogue>>(catalogues);
            return businessCatalogues;
        }

        private List<ProxyCatalogueContract.Catalogue> ConvertToProxy(
            List<BusinessCatalogueContract.Catalogue> catalogues)
        {
            return new List<ProxyCatalogueContract.Catalogue>();
        }

        # endregion
    }
}
