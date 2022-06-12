using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.RoomImages;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class RoomImagesService : IRoomImagesService
    {
        private readonly IRoomImagesRepository _repository;
        private readonly IMapper _mapper;

        public RoomImagesService(IRoomImagesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<RoomImagesDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<RoomImagesDto>>(result);
        }
        public async Task InsertAsync(CreateRoomImageDto roomImageDto)
        {
            await _repository.CreateAsync(_mapper.Map<RoomImages>(roomImageDto));

        }
    }
}
