using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsObjectsHelloWorld
{
    class StringsObjectsHelloWorld
    {
        static void Main(string[] args)
        {
            string greetings = "Hello";
            string planet = "World";
            object greetingsPlanet = string.Format(greetings + " " + planet);
            string hiWorld = (string)greetingsPlanet;
            Console.WriteLine(hiWorld);
        }
    }
}
