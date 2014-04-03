using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            decimal eps = 0.000001m;
            Console.WriteLine("Let's compare floating-point numbers (double) with precision eps = 0.000001.");
            Console.WriteLine("Enter your fist (double) number \"a\":");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second (double) number \"b\":");
            double b = double.Parse(Console.ReadLine());
            bool compareAB = Math.Abs(a - b) < 0.000001;
            Console.WriteLine("Result: {0}", compareAB);
            decimal distinctAB = (decimal)a - (decimal)b;
            if (distinctAB < 0)
            {
                distinctAB = distinctAB * (-1);
            }
            if (distinctAB > eps)
            {
                Console.WriteLine("Explanation: The difference of {0} is too big (> eps)", distinctAB);
            }
            if (distinctAB < eps)
            {
                Console.WriteLine("Explanation: The difference {0} < eps", distinctAB);
            }
            if (distinctAB == eps)
            {
                Console.WriteLine("Explanation: Border case. The difference 0.000001 == eps.");
                Console.WriteLine("We consider the numbers are different.");
            }
        }
    }
}