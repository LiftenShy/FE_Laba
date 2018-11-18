using System.Collections.Generic;
using FE_Lab_Beckend.Data.Models;
using FE_Lab_Beckend.Services;
using Microsoft.AspNetCore.Mvc;

namespace FE_Lab_Beckend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IStudentService _studentService;

        public ExamController(IExamService examService, IStudentService studentService)
        {
            _examService = examService;
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Exam>> Get()
        {
            return new JsonResult(_examService.GetExams());
        }
    }
}