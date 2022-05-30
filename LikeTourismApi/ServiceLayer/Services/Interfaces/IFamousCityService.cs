using ServiceLayer.DTOs.FamousCity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IFamousCityService
    {
        Task<List<FamousCityListDto>> GetAllAsync();

        Task InsertAsync(FamousCityCreateDto famousCity);

        Task UpdateAsync(int id, FamousCityEditDto famousCity);

        Task DeleteAsync(int id);

        Task<FamousCityListDto> GetAsync(int id);
    }
}
