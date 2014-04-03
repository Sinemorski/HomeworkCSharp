using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете радиус на окръжност: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = Math.PI * r * 2;
            double area = Math.PI * r * r;
            Console.WriteLine("Периметъра е: {0:0.00}", perimeter);
            Console.WriteLine("Обиколката е: {0:0.00}", area);
        }
    }
}
