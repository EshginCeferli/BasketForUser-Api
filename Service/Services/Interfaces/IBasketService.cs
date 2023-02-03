using Service.Services.DTOs.Basket;

namespace Service.Services.Interfaces
{
    public interface IBasketService
    {
        Task AddBasketAsync(int id);
        Task<List<BasketProductListDto>> GetBasketProductsAsync();
        Task DeleteBasketAsync(int id);
    }
}
