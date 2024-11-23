using firstwebcode.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstwebcode.Pages;

public class IndexModel : PageModel
{
    public Student std { get; set; }
    public void OnPost(Student std)
    {
        ViewData["name"]=std.name;
        ViewData["fathername"]=std.fathername;
        ViewData["cnic"]=std.cnic;
        ViewData["rollno"]=std.rollno;

    }
}