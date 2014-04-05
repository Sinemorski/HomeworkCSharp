using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractThirdBit
{
    class ExtractThirdBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int a = 8; // 00000000 00001000
            int result = a & number;
            if (result == 8)
            {
                Console.WriteLine("The value of the bit #3 of a given number is 1.");
            }
            else
            {
                Console.WriteLine("The value of the bit #3 of a given number is 0.");
            }
        }
    }
}
