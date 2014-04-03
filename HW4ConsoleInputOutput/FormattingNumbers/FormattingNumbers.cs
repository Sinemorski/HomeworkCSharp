using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number (0 <= number <= 500): ");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a > 500)
            {
                Console.WriteLine("Incorrect value of the number!");
                Console.Write("Try again (0 <= number <= 500): ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a floating-point number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter second floating-point number: ");
            double c = double.Parse(Console.ReadLine());
            string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine(" result ");
            Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|", a, binaryA, b, c);
        }
    }
}
