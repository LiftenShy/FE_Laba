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

        public List<Exam> GetExams()
        {
            return _examRepository.Table.Select(x => x).ToList();
        }

        public Exam GetExam(int id)
        {
            return _examRepository.Table.FirstOrDefault(x => x.Id == id);
        }

        public void AddExam(Exam model)
        {
            _examRepository.Insert(model);
        }

        public void DeleteExam(int id)
        {
            var exam = GetExam(id);
            _examRepository.Delete(exam);
        }
    }
}
