using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class User: AuditExtensions
    {
        public int PublicUserId { get; set; }
        public PublicUser PublicUser { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
