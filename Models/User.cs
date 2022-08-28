using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ADHD.Models.Exercise;
using Microsoft.AspNetCore.Identity;

namespace ADHD.Models
{
    public enum Gender { Male , Female };
    public enum UserRole { Student , Teacher , Consultant}
    public class User 
    {
        public IdentityUser IdentityUser { get; set; }
        public int Id { get; init; }
        public Gender Gender { get; init; }
        public int Age { get; init; }
        public UserRole UserRole { get; set; }
        public string? ImageId { get; set; } = string.Empty;
        public byte IsDeleted { get; set; }
        public List<DailyMood> DailyMood { get; set; }
        public ICollection<MoodJournal> MoodJournal { get; set; }
        public ICollection<Story> Story { get; set; }
    }
}
