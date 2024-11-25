using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Registration_form.Model;

namespace Registration_form.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public StudentData SD { get; set; }
    public void OnPost()
    {
        ViewData["Name"] = SD.name;
        ViewData["FatherName"] = SD.fathername;
        ViewData["Cnic"] = SD.cnic;
        ViewData["Classs"] =SD.classs;
        ViewData["RollNO"] = SD.rollno;
    }
}