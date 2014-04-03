using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да изпечатим n на брой числа от редицата от числа на Фибоначи.");
            Console.Write("Въведете числото \"n\": ");
            int n = int.Parse(Console.ReadLine());
            ulong first = 0;
            ulong second = 1;
            if (n == 0)
            {
                Console.WriteLine(first);
            }
            if (n > 0)
            {
                Console.Write("0 1 ");
                for (int i = 1; i <= n - 2; i++)
                {
                    ulong third = first + second;
                    Console.Write(third + " ");
                    first = second;
                    second = third;
                }
            }
        }
    }
}