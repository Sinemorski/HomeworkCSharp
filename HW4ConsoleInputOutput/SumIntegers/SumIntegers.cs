using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да сметнем сумата на три числа");
            Console.Write("Въведете 1-вото число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведете 2-рото число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Въведете 3-тото число: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Сумата им е: ");
            double sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
