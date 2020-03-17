using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLClass1
    {
        int r = 0, r1 = 0;
        public int Divide(string Numerator,string Denominator)
        {
            bool n = int.TryParse(Numerator, out r);
            bool n1= int.TryParse(Denominator, out r1);
            if (n && n1)
            {
                if (r1 != 0)
                    return r/r1;
                else
                    throw new DivideByZeroException("Cannot divide by zero");

            }
            else
                throw new FormatException("only numbers");
        }
       
    }
}
