using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpfistcode
{
    public   class age
    {
        public int agee(int DOBYear, int currentYear)
        {
            Console.WriteLine(currentYear -  DOBYear);
            return agee(DOBYear, currentYear);
        }
    }
}
