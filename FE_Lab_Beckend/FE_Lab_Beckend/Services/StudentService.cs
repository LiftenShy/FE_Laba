using System.Collections.Generic;
using System.Linq;
using FE_Lab_Beckend.Data.Interface;
using FE_Lab_Beckend.Data.Models;

namespace FE_Lab_Beckend.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetStudents() => _studentRepository.Table.Select(x => x).ToList();
    }
}
