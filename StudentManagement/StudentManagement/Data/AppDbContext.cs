using System.Data;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;

namespace StudentManagement.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }
    public DbSet<Student> tbl_Student { get; set; }
}