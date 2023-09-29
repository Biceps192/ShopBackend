namespace BackendApp.Models
{
    public class Basket: AuditExtensions
    {
        public int PublicUserId { get; set; }
        public PublicUser PublicUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
