using ADHD.Models;
using System.ComponentModel.DataAnnotations;

namespace ADHD.Dto.user
{
    public class UserDto
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public Gender Gender { get; init; }
        public string Password { get; init; }
        public int Age { get; init; }
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; init; }
        public UserRole Role { get; init; }
    }
}
