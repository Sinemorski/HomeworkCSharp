using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers to see the biggest of them.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("result: ");
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
