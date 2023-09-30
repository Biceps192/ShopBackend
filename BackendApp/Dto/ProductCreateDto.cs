namespace BackendApp.Dto
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public int SubcategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public int Count { get; set; }
    }
}
