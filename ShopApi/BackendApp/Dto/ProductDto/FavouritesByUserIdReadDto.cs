namespace BackendApp.Dto.ProductDto
{
    public class FavouritesByUserIdReadDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
