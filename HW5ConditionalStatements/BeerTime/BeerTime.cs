using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enters a time in format “hh:mm tt”:");
                Console.Write("Example: 2:49 PM: ");
                string beerOrNot = Console.ReadLine();
                DateTime beerTime = DateTime.Parse(beerOrNot);
                DateTime lowestValue = DateTime.Parse("1:00 PM");
                DateTime highestValue = DateTime.Parse("2:59 AM");
                int compareFirst = DateTime.Compare(beerTime, lowestValue);
                int compareSecond = DateTime.Compare(highestValue, beerTime);
                if (DateTime.TryParseExact(beerOrNot, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out beerTime))
                {

                    if (compareFirst >= 0 || compareSecond >= 0)
                    {
                        Console.WriteLine("beer time");
                    }
                    else
                    {
                        Console.WriteLine("non-beer time");
                    }
                }
                else
                {
                    Console.WriteLine("invalid time");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid time");
            }

        }
    }
}