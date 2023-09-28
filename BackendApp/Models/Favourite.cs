namespace BackendApp.Models
{
    public class Favourite: AuditExtensions
    {
        public User User { get; set; }
        public Product Product { get; set; }
        public DateTimeOffset DateAdded { get; set; }
    }
}
