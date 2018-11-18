using FE_Lab_Beckend.Data.Models;
using System.Collections.Generic;
namespace FE_Lab_Beckend.Services
{
    public interface IExamService
    {
        List<Exam> GetExams();

        Exam GetExam(int id);

        void AddExam(Exam model);

        void DeleteExam(int id);
    }
}
