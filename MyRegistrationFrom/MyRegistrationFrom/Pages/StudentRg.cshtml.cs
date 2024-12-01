using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRegistrationFrom.Model;

namespace MyRegistrationFrom.Pages;

public class StudentRg : PageModel
{
    private AppDbContext db;
    public StudentRg(AppDbContext _db)
    {
        db = _db;
    }
    [BindProperty]
    public StudentReg Rg { get; set; }
    public void OnPost()
    {
        db.tbl_MSR.Add(Rg);
        db.SaveChanges();
    }
}