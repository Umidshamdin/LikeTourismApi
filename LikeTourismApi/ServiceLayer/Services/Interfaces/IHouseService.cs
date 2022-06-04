using ServiceLayer.DTOs.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHouseService
    {
        Task<List<HouseListDto>> GetAllAsync();

    }
}
