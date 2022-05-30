using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HotelListService : IHotelListService
    {

        
        private readonly IHotelListRepository _repository;
        private readonly IMapper _mapper;

        public HotelListService(IHotelListRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<HotelListDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<HotelListDto>>(result);
        }

        public async Task InsertAsync(HotelListCreateDto hotelList)
        {
            await _repository.CreateAsync(_mapper.Map<HotelList>(hotelList));

        }
    }
}
