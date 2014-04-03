using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbersBySpace
{
    class SumOfFiveNumbersBySpace
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.ReadLine().Split(' ').Sum(t => Convert.ToDecimal(t)));
            Console.WriteLine("Enters 5 numbers separated by a space:");
            //string[] numbers = Console.ReadLine().Split();
            string[] numbers = new string[5];
            numbers = Console.ReadLine().Split(' ');
            decimal numberOne = decimal.Parse(numbers[0]);
            decimal numberTwo = decimal.Parse(numbers[1]);
            decimal numberThree = decimal.Parse(numbers[2]);
            decimal numberFour = decimal.Parse(numbers[3]);
            decimal numberFive = decimal.Parse(numbers[4]);

            decimal sum = numberOne + numberTwo + numberThree + numberFour + numberFive;

            Console.WriteLine("The sum of the first five numbers is: {0}", sum);
            
        }
    }
}
