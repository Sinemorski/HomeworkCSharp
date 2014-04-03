using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първо число: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Въведете второ число: ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("По-голямото от двете числа е: {0}", Math.Max(a, b));
        }
    }
}
