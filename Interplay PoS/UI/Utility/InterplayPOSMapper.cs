using AutoMapper;
using BL.Contracts.Cart;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public static class InterplayPOSMapper
    {
        public static void Configure()
        {
            Mapper.Initialize(confg =>
            {
                confg.CreateMap<BL.Contracts.Cart.UnitPrice, UI.Model.Cart.UnitPrice>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.SubTotal, UI.Model.Cart.SubTotal>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.LineItem, UI.Model.Cart.LineItem>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.SubTotal2, UI.Model.Cart.SubTotal2>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.Items, UI.Model.Cart.Items>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.Embedded, UI.Model.Cart.Embedded>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.Links, UI.Model.Cart.Links>().ReverseMap();
                confg.CreateMap<BL.Contracts.Cart.Self, UI.Model.Cart.Self>().ReverseMap();

                confg.CreateMap<Proxy.Contracts.Cart.UnitPrice, BL.Contracts.Cart.UnitPrice>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.SubTotal, BL.Contracts.Cart.SubTotal>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.LineItem, BL.Contracts.Cart.LineItem>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.SubTotal2, BL.Contracts.Cart.SubTotal2>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.Items, BL.Contracts.Cart.Items>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.Embedded, BL.Contracts.Cart.Embedded>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.Links, BL.Contracts.Cart.Links>().ReverseMap();
                confg.CreateMap<Proxy.Contracts.Cart.Self, BL.Contracts.Cart.Self>().ReverseMap();

                confg.CreateMap<Proxy.Contracts.Catalogue.Property, BL.Contracts.Catalogue.Property>();
                confg.CreateMap<Proxy.Contracts.Catalogue.SimpleArticle, BL.Contracts.Catalogue.SimpleArticle>();
                confg.CreateMap<Proxy.Contracts.Catalogue.ArticleEntry, BL.Contracts.Catalogue.ArticleEntry>();
                confg.CreateMap<Proxy.Contracts.Catalogue.ProductEntry, BL.Contracts.Catalogue.ProductEntry>();
                confg.CreateMap<Proxy.Contracts.Catalogue.Catalogue, BL.Contracts.Catalogue.Catalogue>();
            }
 );
        }
    }
}
