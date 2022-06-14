using ServiceLayer.DTOs.HotelList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHotelListService
    {
        Task<List<HotelListDto>> GetAllAsync(int id);

        Task InsertAsync(HotelListCreateDto hotelList);

        Task<HotelListDto> GetAsync(int id);



    }
}
