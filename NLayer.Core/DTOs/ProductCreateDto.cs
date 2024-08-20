namespace NLayer.Core.DTOs
{
    public class ProductCreateDto
    {
        public string Name { get; set; } = null!;
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
