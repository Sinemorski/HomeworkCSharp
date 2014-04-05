using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight, pleace:");
            double earthWeight = double.Parse(Console.ReadLine());
            double moonWeight;
            moonWeight = earthWeight * (17.0 / 100.0);
            Console.WriteLine("Your weight on the Moon is approximately {0} kg.", moonWeight);
        }
    }
}
