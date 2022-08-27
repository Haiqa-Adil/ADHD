using ADHD.Dto.student;
using ADHD.Middleware;
using ADHD.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private IStudentRepsitory studentRepsitory;
        private IMapper mapper;
        public StudentController(IStudentRepsitory studentRepsitory , IMapper mapper)
        {
            this.studentRepsitory = studentRepsitory;
            this.mapper = mapper;
        }

        [HttpPost("student")]
        public async Task<IActionResult> AddStudent(AddStudentDto studentDto)
        {
            var studentModel = mapper.Map<Student>(studentDto);
            await studentRepsitory.AddStudent(studentModel);
            return Ok(studentModel);
        }

        [HttpGet("student/{userId}")]
        public async Task<IActionResult> GetStudent(int userId)
        {
            var student = await studentRepsitory.GetStudents(userId);
            var studentDto = new List<GetStudentDto>();
            student.ForEach( x => studentDto.Add(mapper.Map<GetStudentDto>(x)));
            return Ok(studentDto);
        }

        [HttpGet("student/user/{studentId}")]
        public async Task<IActionResult> GetStudentById(string studentId)
        {
            var student = await studentRepsitory.GetStudentById(Guid.Parse(studentId));
            var studentDto = mapper.Map<GetStudentDto>(student);
            return Ok(studentDto);
        }
    }
}
