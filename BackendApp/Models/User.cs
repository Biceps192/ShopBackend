using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace BackendApp.Models
{
    public class User: AuditExtensions
    {
        public int PubclicUserId { get; set; }
        public PublicUser PublicUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
