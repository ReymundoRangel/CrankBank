using Microsoft.EntityFrameworkCore;

namespace CrankBank.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options) { }
        public StudentContext() { }
        public DbSet<AccountSummaries> AccountSummaries { get; set; }
        public DbSet<StudentMasters> StudentMasters { get; set; }
    }
}
