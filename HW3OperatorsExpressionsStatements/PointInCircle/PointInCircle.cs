using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's check if given point Z (x,  y) is inside a circle K({0, 0}, 2)");
            Console.WriteLine("Enter coordinate X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate Y:");
            double y = double.Parse(Console.ReadLine());
            bool z = (x * x) + (y * y) <= 4;
            Console.WriteLine("Is it Z inside the circle?");
            Console.WriteLine("Answer: {0}", z);
        }
    }
}
