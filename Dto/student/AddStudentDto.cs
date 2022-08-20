using ADHD.Models;

namespace ADHD.Dto.student
{
    public class AddStudentDto
    {
        public string Name { get; init; }
        public int Age { get; init; } 
        public Gender Gender { get; init; }
        public int UserId { get; set; } 
    }
}
