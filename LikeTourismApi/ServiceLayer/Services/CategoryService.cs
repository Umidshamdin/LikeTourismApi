using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Category;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<CategoryDto>>(result);
        }
    }
}
