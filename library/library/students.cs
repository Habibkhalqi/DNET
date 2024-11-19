using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class students
    {
        public string name { get; set; }
        public string classs { get; set; }
        protected string Attendece { get; set; }
        private int  Grades { get; set; }
        public void setdetails()
        {
            Console.Write("Enter Your Name:");
            name = Console.ReadLine();
            Console.Write("Enter Your Class:");
            classs = Console.ReadLine();
            Console.Write("Enter YOur Attendence:");
            Attendece = Console.ReadLine();
            Console.Write("Enter Your Grades");
            Grades = int.Parse(Console.ReadLine());
        }
        public void showDetails()
        {
            Console.WriteLine("Your Name is :" + name);
            Console.WriteLine("YOur Class is :" + classs);
            Console.WriteLine("Your Attendence is:" + Attendece);
            Console.WriteLine("Your Grades is:" + Grades);
        }
        public void showGrades()
        {
            Console.WriteLine("Enter Your Grades:");
            Grades = int.Parse(Console.ReadLine());
          
        }
    }
}
