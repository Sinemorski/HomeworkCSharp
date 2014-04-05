using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нека изчислим от дадено число стойността на даден бит.");
            Console.WriteLine("Въведете числото:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Двоично преставяне на вашето число е: " + Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Въведете позицията на бита, който да изчислим:");
            int p = int.Parse(Console.ReadLine());          
            int result = n >> p;
            int bit = result & 1;
            Console.WriteLine("На въведената позиция отговяра бит {0} ", bit);
        }
    }
}