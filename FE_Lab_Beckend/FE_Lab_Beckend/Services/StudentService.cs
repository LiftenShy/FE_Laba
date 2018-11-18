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

        public List<Student> GetStudents()
        {
            return _studentRepository.Table.Select(x => x).ToList();
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.Table.FirstOrDefault(x => x.Id == id);
        }

        public void AddStudent(Student model)
        {
            _studentRepository.Insert(model);
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudent(id);
            _studentRepository.Delete(student);
        }
    }
}
