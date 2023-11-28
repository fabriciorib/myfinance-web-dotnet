using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Models.Mappers
{
    public class PlanoContaMap : Profile
    {
        public PlanoContaMap()
        {
            CreateMap<PlanoConta, PlanoContaModel>().ReverseMap();
        }
    }
}