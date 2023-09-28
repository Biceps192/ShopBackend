namespace BackendApp.Models
{
    public class Basket: AuditExtensions
    {
        public PublicUser PublicUser { get; set; }
        public Product Product { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
