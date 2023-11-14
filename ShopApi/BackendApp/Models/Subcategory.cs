

namespace BackendApp.Models
{
    public class Subcategory: AuditExtensions
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
