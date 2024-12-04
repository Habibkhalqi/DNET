using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace MyRegistrationFrom.Model;

public class StudentReg
{
    public int id { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    public string  name { get; set; }
    
    [Required(ErrorMessage = "FatherName is required")]
    public string  FatherName { get; set; }
    
    [Required(ErrorMessage = "CNIC is required")]
    
    public string CNIC { get; set; }
    
    [Required(ErrorMessage = "PhoneNumber is required")]
    public string  phone { get; set; }
    
    [Required(ErrorMessage = "Class is required")]
    public string Class { get; set; }
    
    [Required(ErrorMessage = "Session is required")]
    public string Session { get; set; }

    [Required(ErrorMessage = "Semeter is required")]
    [Range(1, 8)]
    public int semester { get; set; }
}