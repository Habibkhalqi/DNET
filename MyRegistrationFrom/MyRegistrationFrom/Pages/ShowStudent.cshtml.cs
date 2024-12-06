using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRegistrationFrom.Model;

namespace MyRegistrationFrom.Pages;

public class ShowStudent : PageModel
{
    private AppDbContext db;

    public ShowStudent(AppDbContext _db)
    {
        db = _db;
        
    }

    public List<StudentReg> std { get; set; } = new();
    public void OnGet()
    {
        std = db.tbl_MSR.ToList();
    }

    public IActionResult OnGetDelete(int id)
    {
       var DeleteData = db.tbl_MSR.Find(id);
           db.tbl_MSR.Remove(DeleteData);
           db.SaveChanges();
           return RedirectToPage("ShowStudent");
           
    }
}