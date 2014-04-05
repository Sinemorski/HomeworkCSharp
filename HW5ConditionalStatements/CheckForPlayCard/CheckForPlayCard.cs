using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a strin to see is it valid card sign?");
            string isCard = Console.ReadLine();
            switch (isCard)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("yes");
                    break;
                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}