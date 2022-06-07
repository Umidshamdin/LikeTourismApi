using ServiceLayer.DTOs.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IReservationService
    {
        Task<List<ReservationDto>> GetAllAsync();

        Task InsertAsync(ReservationCreateDto reservation);
        Task<ReservationDto> GetAsync(int id);




    }
}
