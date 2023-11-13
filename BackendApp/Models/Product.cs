using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class Product: AuditExtensions
    {
        public string Name { get; set; }
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int Count { get; set; }
        public ICollection<ProductBasket> ProductBasket { get; set; }
    }
}
