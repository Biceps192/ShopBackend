namespace BackendApp.Models
{
    public class Basket: AuditExtensions
    {
        public int PublicUserId { get; set; }
        public PublicUser PublicUser { get; set; }
        public ICollection<ProductBasket> ProductBasket { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public decimal Price { get; set; }
    }
}
