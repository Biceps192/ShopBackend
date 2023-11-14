using System.ComponentModel.DataAnnotations;

namespace BackendApp.Dto.UserDto
{
    public class UserCreateDto
    {
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
