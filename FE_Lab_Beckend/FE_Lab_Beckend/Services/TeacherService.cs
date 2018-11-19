using FE_Lab_Beckend.Data.Models;
using System.Collections.Generic;
using System.Linq;
using FE_Lab_Beckend.Data.Interface;

namespace FE_Lab_Beckend.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> _teacherRepository;

        public TeacherService(IRepository<Teacher> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public List<Teacher> GetTeachers()
        {
            return _teacherRepository.Table.Select(x => x).ToList();
        }

        public Teacher GetTeacher(int id)
        {
            return _teacherRepository.Table.FirstOrDefault(x => x.Id == id);
        }

        public void AddTeacher(Teacher model)
        {
            _teacherRepository.Insert(model);
        }

        public void DeleteTeacher(int id)
        {
            var teacher = GetTeacher(id);
            _teacherRepository.Delete(teacher);
        }
    }
}
