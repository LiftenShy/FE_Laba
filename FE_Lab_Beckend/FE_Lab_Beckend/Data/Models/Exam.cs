using System.Collections.Generic;

namespace FE_Lab_Beckend.Data.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
