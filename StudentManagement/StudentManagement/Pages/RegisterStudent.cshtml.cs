using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagement.Data;
using StudentManagement.Model;

namespace StudentManagement.Pages;

public class RegisterStudent : PageModel
{
    private AppDbContext db;

    public RegisterStudent(AppDbContext _db)
    {
        db = _db;
    }

    public Student student { get; set; } = new();
    public IActionResult  OnPost()
    {
        db.tbl_Student.Add(student);
        db.SaveChanges();
        return RedirectToPage("RegisterStudent");
    }
}