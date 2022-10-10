using Business.Implementation;
using Business.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models.Models;
using System.Collections.Generic;

namespace Student_manager.Controllers
{
    [ApiController]
    [Route("[/api/Students]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsInterface _students;
        private IConfiguration _configuration;

        public StudentsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _students = new StudentsService(_configuration);
        }

        [HttpGet]
        [Route("/api/Students/GetStudents")]
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students = _students.GetStudents();
            return students;
        }
    }
}
