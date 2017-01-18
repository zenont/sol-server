﻿using AutoMapper;
using Sol.DTO;
using Sol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.WebAPI.Mapping
{
    public class AutomapperConfig
    {
        public static void ConfigureMapper(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Invoice, InvoiceDTO>();
            cfg.CreateMap<InvoiceDTO, Invoice>()
                .ForMember(d => d.ZoneId, o => o.MapFrom(s => s.Zone.Id));

            cfg.CreateMap<Zone, ZoneDTO>().ReverseMap();
            cfg.CreateMap<Market, MarketDTO>().ReverseMap();
        }

        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(ConfigureMapper);
            return config.CreateMapper();
        }
    }
}
