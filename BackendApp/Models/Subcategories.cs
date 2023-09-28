using System.Reflection.Metadata.Ecma335;

namespace BackendApp.Models
{
    public class Subcategories: AuditExtensions
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
