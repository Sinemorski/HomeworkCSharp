using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числото:");
            long n = long.Parse(Console.ReadLine());           
            Console.Write("Въведи начална позиция на първия интервал от битове: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Въведи начална позиция на втория интервал от битове: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Въведи дължина на интервала: ");
            int k = int.Parse(Console.ReadLine());

            if (p + k-1 > 31 || q + k-1 > 31)
            {
                Console.WriteLine("out of range");
                return;
            }
            if (p + k-1 >= q || q + k-1 >= p)
            {
                Console.WriteLine("overlapping");
                return;
            }
            for (int i = 1; i <= k; i++)
            {
                long getBitFirst = (n >> p) & 1;
                long getBitSec = (n >> q) & 1;
                if (getBitFirst == 1)
                {
                    n = n | (1 << q);
                }
                if (getBitFirst == 0)
                {
                    n = n & (~(1 << q));
                }
                if (getBitSec == 1)
                {
                    n = n | (1 << p);
                }
                if (getBitSec == 0)
                {
                    n = n & (~(1 << p));
                }
                p++;
                q++;
            }
            Console.WriteLine("Двоично преставяне на въведеното число е: \n" + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Двоично преставяне на новото число е: \n" + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Полученото число е: {0}", n);  
        }
    }
}
