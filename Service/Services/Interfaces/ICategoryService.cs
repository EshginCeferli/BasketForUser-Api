using Service.Services.DTOs.Category;

namespace Service.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryListDto>> GetAllAsync();

    }
}
