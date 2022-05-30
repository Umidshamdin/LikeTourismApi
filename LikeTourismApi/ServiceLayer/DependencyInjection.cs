using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.DTOs.HotelList;
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



            services.AddTransient<IValidator<FamousCityCreateDto>, FamousCityCreateValidator>();
            services.AddTransient<IValidator<SliderCreateDto>, SliderCreateValidator>();




            services.AddTransient<IValidator<HotelListCreateDto>, HotelListCreateValidator>();

            return services;
        }
    }
}
