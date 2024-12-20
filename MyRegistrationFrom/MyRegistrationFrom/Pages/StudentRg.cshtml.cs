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
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            db.tbl_MSR.Add(Rg);
            db.SaveChanges();
            return RedirectToPage("StudentRg");
        }
        
        return Page();
        
    }
}