using FE_Lab_Beckend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FE_Lab_Beckend.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}
