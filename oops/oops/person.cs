using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public  class Person
    {
        public string name { get; set; }
        public string FatherName { get; set; }
        public int age { get; set; }
        public string contact { get; set; }
        public void ShowResults(string name, string FatherName, int age, string contact)
        {

            Console.WriteLine(this.name = name);
            Console.WriteLine(this.FatherName = FatherName);
            Console.WriteLine(this.age = age);
            Console.WriteLine(this.contact = contact);


        }
    }

   
}
