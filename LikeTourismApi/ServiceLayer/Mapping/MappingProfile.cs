using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.FamousCity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<FamousCity, FamousCityListDto>().ReverseMap();
            CreateMap<FamousCity, FamousCityCreateDto>().ReverseMap();
            CreateMap<FamousCity, FamousCityEditDto>().ReverseMap().ForAllMembers(m => m.Condition((src, desc, obj) => obj != null));



        }
    }
}
