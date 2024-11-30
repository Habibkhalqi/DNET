using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRegistrationFrom.Pages;

public class IndexModel : PageModel
{
    public string  Name { get; set; }
    public void OnGet(string name)
    {
        @Name = name;
    }

  
}