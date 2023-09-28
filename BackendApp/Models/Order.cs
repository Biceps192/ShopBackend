using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class Order: AuditExtensions
    {
        public DateTime OrderDate { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
        public PublicUser PublicUser { get; set; }
    }
}
