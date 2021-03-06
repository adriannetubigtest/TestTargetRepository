﻿using AutoMapper;
using ExternalSiteInvestigationBusiness.Entities;
using ExternalSiteInvestigationBusiness.Models;

namespace ExternalSiteInvestigationApi.Helper
{
    public static class AutoMapperConfig
    {
        public static IMapper Config()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.CreateMap<EntityOrder, Order>().ReverseMap();
                mc.CreateMap<EntityDomainCheck, DomainCheck>().ReverseMap();
                mc.CreateMap<EntityIpAddressCheck, IpAddressCheck>().ReverseMap();
                mc.CreateMap<EntityIpScan, IpScan>().ReverseMap();
                mc.CreateMap<EntityAttributes, Attributes>().ReverseMap();
                mc.CreateMap<EntityLinks, Links>().ReverseMap();
            });

            IMapper mapper = mappingConfig.CreateMapper();
            return mapper;
        }
    }
}
