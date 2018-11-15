using System.Collections.Generic;

namespace FE_Lab_Beckend.Data.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
