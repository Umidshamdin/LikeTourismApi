using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.DTOs.Slider;
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
            CreateMap<HotelList, HotelListDto>().ReverseMap();
            CreateMap<Slider, SliderDto>().ReverseMap();


            CreateMap<FamousCity, FamousCityCreateDto>().ReverseMap();
            CreateMap<HotelList, HotelListCreateDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();


            CreateMap<FamousCity, FamousCityEditDto>().ReverseMap();



        }
    }
}
