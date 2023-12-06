using System.ComponentModel.DataAnnotations;

namespace BackendApp.Dto.UserDto
{
    public class LoginDto
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
