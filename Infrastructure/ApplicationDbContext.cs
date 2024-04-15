using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(string connectionString) : base(BuildDbContextOptions(connectionString))
        {
        }
        public static DbContextOptions<ApplicationDbContext> BuildDbContextOptions(string connectionString)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionString);
            return dbContextOptionsBuilder.Options;
        }
       
    }
}
