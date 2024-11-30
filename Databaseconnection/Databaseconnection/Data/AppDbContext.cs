using Databaseconnection.Model;
using Microsoft.EntityFrameworkCore;

namespace Databaseconnection.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> tbl_Student{ get; set; }
        public DbSet<teacher> tbl_teacher { get; set; }
    }
}
