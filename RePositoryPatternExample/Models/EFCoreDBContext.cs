using Microsoft.EntityFrameworkCore;

namespace RePositoryPatternExample.Models
{
    public class EFCoreDBContext : DbContext
    {
        public EFCoreDBContext(DbContextOptions<EFCoreDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dept> Depts { get; set; }
    }
}
