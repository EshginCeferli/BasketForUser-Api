using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.Services.DTOs.Product;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task Createasync(ProductCreateDto product)
        {
            var mappedData = _mapper.Map<Product>(product);
            await _repo.Create(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _repo.Get(id);
            await _repo.Delete(product);
        }

        public async Task<List<ProductListDto>> GetAllAsync()
        {

            return _mapper.Map<List<ProductListDto>>(await _repo.GetAll());
        }

        public async Task SoftDeleteAsync(int id)
        {
            Product product = await _repo.Get(id);
            await _repo.SoftDelete(product);
        }

        public async Task UpdateAsync(int id, ProductUpdateDto product)
        {
            var dbProduct = await _repo.Get(id);

            _mapper.Map(product, dbProduct);

            await _repo.Update(dbProduct);
        }

        public async Task<List<ProductListDto>> SearchAsync(string? searchText)
        {
            List<Product> searchDatas = new();

            if (searchText != null)
            {
                //var data = _repo.FindAllByExpressionAsync(m => m.CategoryId == m.Category.Id);
                searchDatas = await _repo.FindAllByExpressionAsync(m => m.Name.Contains(searchText));
            }
            else
            {
                searchDatas = await _repo.GetAll();
            }

            return _mapper.Map<List<ProductListDto>>(searchDatas);
        }

        public async Task<ProductGetDto> GetByIdAsync(int id)
        {
            var mappedProduct = _mapper.Map<ProductGetDto>(await _repo.Get(id));

            return mappedProduct;
        }
    }
}
