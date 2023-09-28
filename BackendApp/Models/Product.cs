using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class Product: AuditExtensions
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
