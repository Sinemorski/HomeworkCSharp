using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an exactly four-digit number which cannot start with 0 (e.g. 2588).");
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = abcd / 100 % 10;
            int c = abcd / 10 % 10;
            int d = abcd % 10;

            Console.Write("Sum of digits: ");
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, b, c, a);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
