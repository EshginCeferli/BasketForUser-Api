using AutoMapper;
using Repository.Repositories.Interfaces;
using Service.Services.DTOs.Category;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> GetAllAsync()
        {
            var categories = await _repo.GetAllCategories();
            var result = _mapper.Map<List<CategoryListDto>>(categories);
            return result;
        }
    }
}
