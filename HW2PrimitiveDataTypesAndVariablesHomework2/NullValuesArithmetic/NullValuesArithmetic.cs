using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine("Null values to an integer and to a double variable is:");
            Console.WriteLine("Integer null is = {0}", nullInt);
            Console.WriteLine("Double null is = {0}", nullDouble);
            Console.WriteLine("Null value is printed as empty space.");
            Console.WriteLine("Null integer + 5 = " + (nullInt + 5));
            nullInt = nullInt + 5;
            Console.WriteLine("Null is not = " + nullInt.GetValueOrDefault());
            Console.WriteLine("Null double + 10 = " + (nullDouble + 10));
            Console.WriteLine("When we get value or default the result is = " + (nullDouble.GetValueOrDefault() + 10));
        }
    }
}