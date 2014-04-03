using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да пресметнем n брой числа.");
            Console.Write("Въведете броя на числата \"n\": ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете числата:");
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum = sum + numbers;
            }
            Console.WriteLine("Тяхната сума е: {0}", sum);
        }
    }
}
