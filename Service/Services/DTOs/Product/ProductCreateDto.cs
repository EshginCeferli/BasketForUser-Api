namespace Service.Services.DTOs.Product
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }

        //public int CategoryId { get; set; }
    }
}
