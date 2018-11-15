using System.Collections.Generic;

namespace FE_Lab_Beckend.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public virtual Group Group { get; set; }
        
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
