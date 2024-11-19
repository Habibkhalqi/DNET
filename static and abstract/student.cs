namespace DefaultNamespace;

public static class student
{
    public static string  name { get; set; }
    public static string fatherName { get; set; }
    public static string CNIC { get; set; }
    public static string Age { get; set; }
    public static void ShowDetails()
    {
        console.WriteLine("Your Name is:" + name);
        console.WriteLine("Your Father Name is:" + fatherName);
        console.WriteLine("Your CNIC Number is:" + CNIC);
        console.WriteLine("Your Age is:" + Age);
    }
}