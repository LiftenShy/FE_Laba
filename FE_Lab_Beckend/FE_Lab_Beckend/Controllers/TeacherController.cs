using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FE_Lab_Beckend.Data.Models;
using FE_Lab_Beckend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FE_Lab_Beckend.Controllers
{
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return new JsonResult(_teacherService.GetTeachers());
        }

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return new JsonResult(_teacherService.GetTeacher(id));
        }

        [HttpPost]
        public void Post([FromBody]Teacher model)
        {
            _teacherService.AddTeacher(model);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _teacherService.DeleteTeacher(id);
        }
    }
}
