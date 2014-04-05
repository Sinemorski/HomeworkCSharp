using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Console.Write("Please enter an int: ");
                    int numberInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(numberInt + 1);
                    break;
                case "2":
                    Console.Write("Please enter a double: ");
                    double numberDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(numberDouble + 1);
                    break;
                case "3":
                    Console.Write("Please enter a string: ");
                    string userString = Console.ReadLine();
                    Console.WriteLine(userString + "*");
                    break;
                default:
                    Console.WriteLine("You chose a non-existent type!");
                    break;
            }
        }
    }
}