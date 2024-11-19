namespace static_and_abstract;

public static  class student
{
    public static string name { get; set; }
    public static string FatherName { get; set; }
    public static string CNIC { get; set; }
    public static int age { get; set; }

    public static void PrintStudent()
    {
        Console.WriteLine("Your Name is:" + name);
        Console.WriteLine("Your FatherName is:" + FatherName);
        Console.WriteLine("Your CNIC Number is:" + CNIC);
        Console.WriteLine("Your Age is:" + age);
    }
}