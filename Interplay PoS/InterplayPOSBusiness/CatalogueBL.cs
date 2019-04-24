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

        public CatalogueBL()
        {
            this.service = new CatalogueService(new Credential { UserName = "admin", Password = "admin"});
            this.ConfigAutoMapper();
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

        private void ConfigAutoMapper()
        {
            Mapper.Initialize(confg =>
            {
                confg.CreateMap<ProxyCatalogueContract.Property, BusinessCatalogueContract.Property>();
                confg.CreateMap<ProxyCatalogueContract.SimpleArticle, BusinessCatalogueContract.SimpleArticle>();
                confg.CreateMap<ProxyCatalogueContract.ArticleEntry, BusinessCatalogueContract.ArticleEntry>();
                confg.CreateMap<ProxyCatalogueContract.ProductEntry, BusinessCatalogueContract.ProductEntry>();
                confg.CreateMap<ProxyCatalogueContract.Catalogue, BusinessCatalogueContract.Catalogue>();
            }
            );

        }

        # endregion
    }
}
