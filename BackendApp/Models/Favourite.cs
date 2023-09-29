namespace BackendApp.Models
{
    public class Favourite: AuditExtensions
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTimeOffset DateAdded { get; set; }
    }
}
