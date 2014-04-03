using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInIntervalFive
{
    class NumbersInIntervalFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте начало и край на поредица от числа.");
            Console.Write("Въведете число за начало: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Въведете число за край: ");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("Броя на кратните на 5 в поредица е: {0}", sum);
            Console.WriteLine("Самите кратни са:");
            for (int j = start; j <= end; j++)
            {
                if (j % 5 == 0)
                {
                    Console.Write(j + ", ");
                }
            }
        }
    }
}
