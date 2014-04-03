using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Result:");
            for (int i = 1; i <= n; i++)
            {              
                Console.WriteLine(i);
            }
        }
    }
}
