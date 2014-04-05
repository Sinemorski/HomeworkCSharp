using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitPosition
{
    class ModifyBitPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("От дадено число да зададем стойност на бит" + "\n(0 или 1) в съответна зададена позиция.");
            Console.WriteLine("Въведете числото:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Двоично преставяне на вашето число е: " + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Въведете позицията на бита, който да зададем:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете стойността на бита (0 или 1):");
            int v = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                n = n | (1 << p);
            }
            if (v == 0)
            {
                n = n & (~(1 << p));
            }
            if (v != 1 && v != 0)
            {
                Console.WriteLine("Невалидна стойност на бита!");
                return;
            }
            Console.WriteLine("Двоично преставяне на полученото число: " + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Полученото число е: {0}", n);
        }
    }
}
