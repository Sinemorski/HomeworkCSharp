using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00a9';
            Console.WriteLine("    {0}", symbol);
            Console.WriteLine("   {0} {0}", symbol);
            Console.WriteLine("  {0}   {0}", symbol);
            Console.WriteLine(" {0} {0} {0} {0}", symbol);
        }
    }
}
