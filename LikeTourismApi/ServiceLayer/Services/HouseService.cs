using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.House;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HouseService : IHouseService
    {

        private readonly IHouseRepository _repository;
        private readonly IMapper _mapper;

        public HouseService(IHouseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<HouseListDto>> GetAllAsync()
        {
            var result = await _repository.GetAllHouseAsync();
            return _mapper.Map<List<HouseListDto>>(result);
        }

        public async Task InsertAsync(HouseCreateDto house)
        {
            await _repository.CreateAsync(_mapper.Map<House>(house));

        }
    }
}
