using Microsoft.EntityFrameworkCore;
using Core;

namespace Infrastructure
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)   
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
