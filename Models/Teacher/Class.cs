namespace ADHD.Models.Teacher
{
    public class Class
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public ICollection<TeacherClass> TeacherClass { get; set; }
    }
}
