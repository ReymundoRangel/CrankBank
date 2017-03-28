using Microsoft.EntityFrameworkCore;

namespace CrankBank.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options) { }
        public StudentContext() { }
        public DbSet<StudentMasters> StudentMasters { get; set; }
    }
}
