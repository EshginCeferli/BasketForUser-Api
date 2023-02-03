namespace Service.Services.DTOs.Product
{
    public class ProductGetDto
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
