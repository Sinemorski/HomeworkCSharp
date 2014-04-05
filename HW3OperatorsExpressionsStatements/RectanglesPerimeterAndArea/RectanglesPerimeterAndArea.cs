using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglesPerimeterAndArea
{
    class RectanglesPerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate perimeter and area of a rectangle.");
            Console.WriteLine("Enter his width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter his height:");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("Rectangle’s perimeter is: {0}", perimeter);
            Console.WriteLine("Rectangle’s area is: {0}", area);
        }
    }
}