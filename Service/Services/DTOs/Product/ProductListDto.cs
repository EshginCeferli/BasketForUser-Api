using Service.Services.DTOs.Category;

namespace Service.Services.DTOs.Product
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public string CreateDate { get; set; }
        public int CategoryId { get; set; }
        public CategoryListDto? Category { get; set; }
    }
}
