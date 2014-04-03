using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValuesInt
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Original values");
            Console.WriteLine(a + "\n" + b);
            a = a + b; // a = 5 + 10 (a=15)
            b = a - b; // b = 15 - 10 (b=5)
            a = a - b; // a = 15 - 5 (a=10)
            Console.WriteLine("Exchange values");
            Console.WriteLine(a + "\n" + b);
        }
    }
}
