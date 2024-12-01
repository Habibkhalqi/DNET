using System.Data;
using Microsoft.EntityFrameworkCore;
using MyRegistrationFrom;
using MyRegistrationFrom.Model;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }

    public DbSet<StudentReg> tbl_MSR { get; set; }
}