using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class Order: AuditExtensions
    {
        public DateTime OrderDate { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        public decimal Price { get; set; }
    }
}
