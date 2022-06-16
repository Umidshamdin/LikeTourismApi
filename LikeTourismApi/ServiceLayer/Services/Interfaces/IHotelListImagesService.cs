using ServiceLayer.DTOs.HotelListImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHotelListImagesService
    {
        Task<List<HotelListImagesDto>> GetAllAsync(int id);
        Task InsertAsync(CreateHotelListImagesDto createHotel);

        Task<HotelListImagesDto> GetAsync(int id);
    }
}
