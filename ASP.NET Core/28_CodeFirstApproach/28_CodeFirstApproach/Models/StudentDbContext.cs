using Microsoft.EntityFrameworkCore;

namespace _28_CodeFirstApproach.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
