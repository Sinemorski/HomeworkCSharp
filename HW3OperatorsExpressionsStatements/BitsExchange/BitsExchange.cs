using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числото:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Двоично преставяне на вашето число е: \n" + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Разменяме стойностите на битовете на позиции \n3, 4 и 5 с битовете на позиции 24, 25 и 26");
            int firstPosition = 3;
            int secPosition = 24;
            for (int i = 1; i <= 3; i++)
            {
                int getBitFirst = (int)(n >> firstPosition) & 1;
                int getBitSec = (int)(n >> secPosition) & 1;
                if (getBitFirst == 1)
                {
                    n = n | (1 << secPosition);
                }
                if (getBitFirst == 0)
                {
                    n = n & (~(1 << secPosition));
                }
                if (getBitSec == 1)
                {
                    n = n | (1 << firstPosition);
                }
                if (getBitSec == 0)
                {
                    n = n & (~(1 << firstPosition));
                }
                firstPosition++;
                secPosition++;
            }
            Console.WriteLine("Двоично преставяне на новото число е: \n" + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Полученото число е: {0}", n);
        }
    }
}
