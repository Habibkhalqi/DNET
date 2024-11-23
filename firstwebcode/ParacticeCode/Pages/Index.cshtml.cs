using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParacticeCode.Pages;

public class IndexModel : PageModel
{
    public string  name { get; set; }

    public void OnGet(string _name)
    {
        name = string.IsNullOrEmpty(_name) ? "habib" : _name;
    }
}