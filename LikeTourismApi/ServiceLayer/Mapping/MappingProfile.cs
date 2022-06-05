using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Category;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.DTOs.House;
using ServiceLayer.DTOs.Reservation;
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
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<House, HouseListDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();





            CreateMap<FamousCity, FamousCityCreateDto>().ReverseMap();
            CreateMap<FamousCity, FamousCityDto>().ReverseMap();
            CreateMap<HotelList, HotelListCreateDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Reservation, ReservationCreateDto>().ReverseMap();
            CreateMap<House, HouseCreateDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();





            CreateMap<FamousCity, FamousCityEditDto>().ReverseMap();
            CreateMap<Slider, SliderEditDto>().ReverseMap();




        }
    }
}
