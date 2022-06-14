using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HotelListImages;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HotelListImagesService : IHotelListImagesService
    {

        private readonly IHotelListImagesRepository _repository;
        private readonly IMapper _mapper;

        public HotelListImagesService(IHotelListImagesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<HotelListImagesDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<HotelListImagesDto>>(result);
        }

        public async Task<HotelListImagesDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<HotelListImagesDto>(model);
            return result;
        }

        public async Task InsertAsync(CreateHotelListImagesDto createHotel)
        {
            await _repository.CreateAsync(_mapper.Map<HotelListImages>(createHotel));

        }
    }
}
