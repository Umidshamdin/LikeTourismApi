using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.DTOs.Category;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.DTOs.HotelListImages;
using ServiceLayer.DTOs.House;
using ServiceLayer.DTOs.Reservation;
using ServiceLayer.DTOs.RoomImages;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<IFamousCityService, FamousCityService>();
            services.AddScoped<IHotelListService, HotelListService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IHouseService, HouseService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IRoomImagesService, RoomImagesService>();
            services.AddScoped<IHotelListImagesService, HotelListImagesService>();








            services.AddTransient<IValidator<FamousCityCreateDto>, FamousCityCreateValidator>();
            services.AddTransient<IValidator<SliderCreateDto>, SliderCreateValidator>();
            services.AddTransient<IValidator<ReservationCreateDto>, ReservationCreateValidator>();
            services.AddTransient<IValidator<HouseCreateDto>, HouseCreateValidator>();
            services.AddTransient<IValidator<CategoryCreateDto>, CategoryCreateValidator>();
            services.AddTransient<IValidator<CreateRoomImageDto>, RoomImagesCreateValidator>();
            services.AddTransient<IValidator<CreateHotelListImagesDto>, HotelListImagesCreateValidator>();



            services.AddTransient<IValidator<HotelListCreateDto>, HotelListCreateValidator>();

            return services;
        }
    }
}
