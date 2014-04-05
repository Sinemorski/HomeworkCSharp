using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да изчислим от дадено число дали стойността на даден бит е 1.");
            Console.WriteLine("Въведете числото:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Двоично преставяне на вашето число е: " + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Въведете позицията на бита, който да проверим:");
            int p = int.Parse(Console.ReadLine());
            int result = n >> p;
            int bit = result & 1;
            bool isBitOne;
            if (bit == 1)
            {

                isBitOne = true;
            }
            else
            {
                isBitOne = false;
            }
            Console.WriteLine("Дали бита е равен на единица: {0}", isBitOne);
        }
    }
}