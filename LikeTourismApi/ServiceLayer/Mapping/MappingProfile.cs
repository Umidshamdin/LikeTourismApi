using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.AppUser;
using ServiceLayer.DTOs.Category;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.DTOs.HotelDescription;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.DTOs.HotelListImages;
using ServiceLayer.DTOs.House;
using ServiceLayer.DTOs.Order;
using ServiceLayer.DTOs.Reservation;
using ServiceLayer.DTOs.RoomImages;
using ServiceLayer.DTOs.Slider;

namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FamousCity, FamousCityListDto>().ReverseMap();
            CreateMap<HotelList, HotelListDto>().ReverseMap();
            CreateMap<Slider, SliderDto>().ReverseMap();
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<House, HouseListDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<RoomImages, RoomImagesDto>().ReverseMap();
            CreateMap<HotelListImages, HotelListImagesDto>().ReverseMap();
            CreateMap<HotelDescription, HotelDescriptionDto>().ReverseMap();
            CreateMap<AppUser, RegisterDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<UserDto, AppUser>().ReverseMap();













            CreateMap<FamousCity, FamousCityCreateDto>().ReverseMap();
            CreateMap<FamousCity, FamousCityDto>().ReverseMap();
            CreateMap<HotelList, HotelListCreateDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Reservation, ReservationCreateDto>().ReverseMap();
            CreateMap<House, HouseCreateDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<RoomImages, CreateRoomImageDto>().ReverseMap();
            CreateMap<HotelListImages, CreateHotelListImagesDto>().ReverseMap();
            CreateMap<HotelDescription, HotelDescriptionCreateDto>().ReverseMap();










            CreateMap<FamousCity, FamousCityEditDto>().ReverseMap();
            CreateMap<Slider, SliderEditDto>().ReverseMap();
            CreateMap<HotelList, HotelListEditDto>().ReverseMap();
            CreateMap<HotelListImages, HotelListImagesEditDto>().ReverseMap();






        }
    }
}
