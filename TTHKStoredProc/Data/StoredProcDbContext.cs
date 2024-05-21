using Microsoft.EntityFrameworkCore;
using TTHKStoredProc.Models;

namespace TTHKStoredProc.Data
{
    public class StoredProcDbContext : DbContext
    {
        public StoredProcDbContext(DbContextOptions<StoredProcDbContext> options)
            : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
