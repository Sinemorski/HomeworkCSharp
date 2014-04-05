using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideCircleOutsideRectangle
{
    class InsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's check if given point Z (x,  y) is inside a circle K({1, 1}, 1.5)");
            Console.WriteLine("and out of the rectangle R(top=1, left=-1, width=6, height=2)");
            Console.WriteLine("Enter coordinate X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate Y:");
            double y = double.Parse(Console.ReadLine());
            bool z = (x - 1) * (x - 1) + (y -1) * (y -1) <= 2.25 && y > 1;
            Console.WriteLine("Is it Z inside the circle and out of the rectangle?");
            Console.WriteLine("Answer: {0}", z);
        }
    }
}

