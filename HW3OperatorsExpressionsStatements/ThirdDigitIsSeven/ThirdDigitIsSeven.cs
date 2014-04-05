using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Its third digit from right-to-left is 7?");
            int a = n / 100;
            bool b = a % 10 == 7;
            Console.WriteLine(b);
        }
    }
}