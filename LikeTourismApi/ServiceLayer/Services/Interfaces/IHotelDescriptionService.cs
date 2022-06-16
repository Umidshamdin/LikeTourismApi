using ServiceLayer.DTOs.HotelDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHotelDescriptionService
    {

        Task<List<HotelDescriptionDto>> GetAllAsync(int id);
        Task InsertAsync(HotelDescriptionCreateDto hotelDescription);

        Task<HotelDescriptionDto> GetAsync(int id);



    }
}
