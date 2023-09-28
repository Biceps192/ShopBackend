using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class AuditExtensions: BaseEntity
    {
        public DateTimeOffset CreatedAt  { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
