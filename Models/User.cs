using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ADHD.Models.Exercise;

namespace ADHD.Models
{
    public enum Gender { Male , Female };
    public enum UserRole { Student , Teacher , Consultant}
    public class User
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public Gender Gender { get; init; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int Age { get; init; }

        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; init; }
        public UserRole UserRole { get; set; }
        public bool IsVerified { get; set; }
        public byte IsDeleted { get; set; }
        public List<DailyMood> DailyMood { get; set; }
        public ICollection<MoodJournal> MoodJournal { get; set; }
        public ICollection<Story> Story { get; set; }
    }
}
