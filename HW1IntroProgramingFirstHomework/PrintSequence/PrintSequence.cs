using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2, g = 3; i <= 10; i = i + 2, g = g + 2)
            {
                Console.Write(i + ", -" + g + ", ");
            }
        }
    }
}