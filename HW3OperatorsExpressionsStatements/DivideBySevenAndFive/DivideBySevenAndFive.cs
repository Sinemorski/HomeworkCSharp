using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it can be divided" + "\n(without remainder) by 7 and 5 in the same time:");
            int n = int.Parse(Console.ReadLine());
            bool a = n % 5 == 0 && n % 7 == 0; // or bool a = n % 35 == 0;
            Console.WriteLine(a);

        }
    }
}