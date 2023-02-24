using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Data
{
    public class OfficeDB : DbContext
    { 
        public OfficeDB(DbContextOptions<OfficeDB> options) : base(options) 
        { 

        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
