using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да пресметнем квадратно уравнение | ax^2 + bx + c = 0 |");
            Console.Write("Задайте стойност на \"а\" различна от нула \"0\": ");
            double a = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Стойността на \"a\" трябва да е различна от нула!");
                Console.Write("Задайте нова стойност на \"а\": ");
                a = double.Parse(Console.ReadLine());
            }

            Console.Write("Задайте стойност на \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Задайте стойност на \"c\": ");
            double c = double.Parse(Console.ReadLine());

            double discriminantD = (b * b) - (4 * a * c);
            if (discriminantD < 0)
            {
                Console.WriteLine("Уравнението няма реални корени.");
            }
            if (discriminantD == 0)
            {
                Console.WriteLine("Уравнението има 1 реален корен.");
                double x = (-b) / (2 * a);
                Console.WriteLine("x1=x2={0}", x);
            }
            if (discriminantD > 0)
            {
                Console.WriteLine("Уравнението има 2 реални корена.");
                double xOne = (-b - Math.Sqrt(discriminantD)) / (2 * a);
                double xTwo = (-b + Math.Sqrt(discriminantD)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}", xOne, xTwo);
            }
        }
    }
}
