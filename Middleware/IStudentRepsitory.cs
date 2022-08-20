using ADHD.Models;

namespace ADHD.Middleware
{
    public interface IStudentRepsitory
    {
        Task<Student> AddStudent(Student student);
        Task<List<Student>> GetStudents(int userId);
    }
}