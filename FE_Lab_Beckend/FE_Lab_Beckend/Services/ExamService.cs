using FE_Lab_Beckend.Data.Interface;
using FE_Lab_Beckend.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace FE_Lab_Beckend.Services
{
    public class ExamService : IExamService
    {
        private readonly IRepository<Exam> _examRepository;

        public ExamService(IRepository<Exam> examRepository)
        {
            _examRepository = examRepository;
        }

        public List<Exam> GetExams() => _examRepository.Table.Select(x => x).ToList();
    }
}
