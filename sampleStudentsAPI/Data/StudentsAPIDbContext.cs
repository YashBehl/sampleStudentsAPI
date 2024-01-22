using Microsoft.EntityFrameworkCore;
using sampleStudentsAPI.Models;

namespace sampleStudentsAPI.Data
{
    public class StudentsAPIDbContext : DbContext
    {
        public StudentsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
