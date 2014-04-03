using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2, g = 3; i <= 1000; i = i + 2, g = g + 2)
            {
                Console.Write(i + ", -" + g + ", ");
            }
        }
    }
}
