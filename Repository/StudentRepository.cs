using ADHD.Data;
using ADHD.Middleware;
using ADHD.Models;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository
{
    public class StudentRepository : IStudentRepsitory
    {
        private DataContext db;
        public StudentRepository(DataContext db)
        {
            this.db = db;
        }
        public async Task<Student> AddStudent(Student student)
        {
            await db.Students.AddAsync(student);
            await db.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetStudents(int userId)
        {
            var students = await db.Students.Where(x => x.UserId == userId).ToListAsync();
            return students;
        }
    }
}
