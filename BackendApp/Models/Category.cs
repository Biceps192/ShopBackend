using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class Category: AuditExtensions
    {
        [MaxLength(120)]
        public string NameOfCategory { get; set; }
    }
}
