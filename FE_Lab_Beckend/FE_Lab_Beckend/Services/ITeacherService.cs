using FE_Lab_Beckend.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_Lab_Beckend.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetTeachers();

        Teacher GetTeacher(int id);

        void AddTeacher(Teacher model);

        void DeleteTeacher(int id);
    }
}
