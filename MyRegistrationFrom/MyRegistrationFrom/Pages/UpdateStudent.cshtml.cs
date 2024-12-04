using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRegistrationFrom.Model;

namespace MyRegistrationFrom.Pages;

public class UpdateStudent : PageModel
{
    private AppDbContext db;

    public UpdateStudent(AppDbContext _db)
    {
        db = _db;
    }
    [BindProperty]
    public StudentReg Rg { get; set; }
    public void OnGet(int id)
    {
        Rg = db.tbl_MSR.Find(id);
    }

    public IActionResult OnPost()
    {
        db.tbl_MSR.Update(Rg);
        db.SaveChanges();
        return RedirectToPage("ShowStudent");
    }
}