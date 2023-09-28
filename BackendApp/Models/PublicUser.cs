using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class PublicUser: AuditExtensions
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
