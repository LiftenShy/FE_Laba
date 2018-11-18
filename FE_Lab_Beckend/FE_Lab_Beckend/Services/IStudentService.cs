using FE_Lab_Beckend.Data.Models;
using System.Collections.Generic;

namespace FE_Lab_Beckend.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
