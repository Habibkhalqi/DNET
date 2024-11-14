using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Function_override
    {
        public int Result { get; set; }
        public void calculator(int math , int phy, int computer)
        {
            Result= math + phy + computer;
            
        }
        public void resultshow()
        {
            Console.WriteLine(Result);
        }


    }
}
