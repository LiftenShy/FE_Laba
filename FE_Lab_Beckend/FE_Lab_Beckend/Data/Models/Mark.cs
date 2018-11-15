
namespace FE_Lab_Beckend.Data.Models
{
    public class Mark
    {
        public int Id { get; set; }

        public int MarkForExam { get; set; }

        public virtual Student Student { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
