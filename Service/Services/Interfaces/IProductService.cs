using Service.Services.DTOs.Product;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        Task Createasync(ProductCreateDto product);
        Task<List<ProductListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, ProductUpdateDto product);
        Task<List<ProductListDto>> SearchAsync(string? searchText);
        Task<ProductGetDto> GetByIdAsync(int id);
    }
}
