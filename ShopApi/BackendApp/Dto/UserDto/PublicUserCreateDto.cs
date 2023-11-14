using System.ComponentModel.DataAnnotations;

namespace BackendApp.Dto.UserDto
{
    public class PublicUserCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
