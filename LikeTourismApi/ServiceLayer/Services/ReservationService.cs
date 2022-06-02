using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Reservation;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class ReservationService : IReservationService
    {

        private readonly IReservationRepository _repository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<ReservationDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<ReservationDto>>(result);
        }
    }
}
