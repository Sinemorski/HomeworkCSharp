using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number <= 100 to see if it is prime:");
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            if (n < 2)
            {
                prime = false;
            }
            if (n > 100)
            {
                Console.WriteLine("The number is too big!");
                return;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine("Is it prime?");
            Console.WriteLine(prime);
        }
    }
}