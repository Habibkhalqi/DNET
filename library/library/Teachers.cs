using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Teachers:students
    {
        public void attendence()
        {
           Attendece =Console.ReadLine();
            Console.WriteLine("Update Attendence:" + Attendece);
        }
        public void ViewGrades()
        {
            Console.WriteLine(showGrades);

        }
    }
}
