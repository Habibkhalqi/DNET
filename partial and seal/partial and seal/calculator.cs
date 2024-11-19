using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_and_seal
{
    internal partial  class calculator
    {
        public int valueOne { get; set; }
        public int valueTwo { get; set; }
        public void sum()
        {
            int sum = valueOne + valueTwo;
            Console.WriteLine("sum of two number is " + sum);
        }
        public void sub()
        {
            int sub = valueOne - valueTwo;
            Console.WriteLine("Sub of two number is : " + sub);
        }

    }
}
