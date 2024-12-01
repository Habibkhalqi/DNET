using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace MyRegistrationFrom.Model;

public class StudentReg
{
    public int id { get; set; }
    public string  name { get; set; }
    public string  FatherName { get; set; }
    public string CNIC { get; set; }
    public string  phone { get; set; }
    public string Class { get; set; }
    public string Session { get; set; }
    public int semester { get; set; }
}