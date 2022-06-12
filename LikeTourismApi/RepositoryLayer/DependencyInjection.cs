using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IFamousCityRepository, FamousCityRepository>();
            services.AddScoped<IHotelListRepository, HotelListRepository>();
            services.AddScoped<ISliderRepository, SliderRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IHouseRepository, HouseRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IRoomImagesRepository, RoomImagesRepository>();







            return services;
        }
    }
}
