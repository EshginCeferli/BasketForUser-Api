using Service.Services.DTOs.Product;

namespace Service.Services.DTOs.Basket
{
    public class BasketProductListDto
    {
        public int Quantity { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public ProductListDto Product { get; set; }
    }
}
