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

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet]
        public ActionResult<List<Exam>> Get()
        {
            return new JsonResult(_examService.GetExams());
        }

        [HttpGet("{id}")]
        public ActionResult<Exam> Get(int id)
        {
            return new JsonResult(_examService.GetExam(id));
        }

        [HttpPost]
        public void Post([FromBody]Exam model)
        {
            _examService.AddExam(model);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _examService.DeleteExam(id);
        }
    }
}