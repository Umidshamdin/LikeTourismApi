using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class SliderService:ISliderService
    {
        private readonly ISliderRepository _repository;
        private readonly IMapper _mapper;

        public SliderService(ISliderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SliderDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<SliderDto>>(result);
        }

        public async Task InsertAsync(SliderCreateDto slider)
        {
            await _repository.CreateAsync(_mapper.Map<Slider>(slider));

        }
    }
}
