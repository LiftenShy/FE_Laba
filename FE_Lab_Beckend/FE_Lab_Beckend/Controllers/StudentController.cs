using System.Collections.Generic;
using FE_Lab_Beckend.Data.Models;
using FE_Lab_Beckend.Services;
using Microsoft.AspNetCore.Mvc;

namespace FE_Lab_Beckend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return new JsonResult(_studentService.GetStudents());
        }

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return new JsonResult(_studentService.GetStudent(id));
        }

        [HttpPost]
        public void Post([FromBody]Student model)
        {
            _studentService.AddStudent(model);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.DeleteStudent(id);
        }
    }
}
