using ADHD.Dto.student;
using ADHD.Middleware;
using ADHD.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepsitory studentRepsitory;
        private IMapper mapper;
        public StudentController(IStudentRepsitory studentRepsitory , IMapper mapper)
        {
            this.studentRepsitory = studentRepsitory;
            this.mapper = mapper;
        }

        public IActionResult AddStudent(AddStudentDto studentDto)
        {
            var studentModel = mapper.Map<Student>(studentDto);
            studentRepsitory.AddStudent(studentModel);
            return View(studentModel);
        }
    }
}
