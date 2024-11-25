using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParacticeCode.Model;

namespace ParacticeCode.Pages;

public class IndexModel : PageModel
{
    public StudentDetails sd { get; set; }
    public void OnPost(StudentDetails sd)
    {
        
        ViewData["Name"] = sd.name;
        ViewData["FatherName"] = sd.fathername;
    }
}