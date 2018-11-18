using FE_Lab_Beckend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FE_Lab_Beckend.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Mark> Marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=7d602c34-758b-4d33-b8a6-a99c01186bb1.sqlserver.sequelizer.com;Database=db7d602c34758b4d33b8a6a99c01186bb1;User ID=hpztitidtfsfwiih;Password=fWB8RYZTs3Y25XopwqyYGxHSoVLRNeChBKLBCgUzSkBz4Am66CYL3CRQoRT4mheo;");
        }
    }
}
