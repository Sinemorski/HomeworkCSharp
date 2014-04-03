using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Please enter your birthday in format: DD.MM.YYYY");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            var age = now.Year - birthday.Year;
            if (birthday.Year > now.Year)
            {
                Console.WriteLine("You are not born yet!");
                return;
            }
            if (birthday.Year == now.Year)
            {
                if (birthday.Month > now.Month)
                {
                    Console.WriteLine("You are not born yet!");
                    return;
                }
                if (birthday.Month == now.Month)
                {
                    if (birthday.Day > now.Day)
                    {
                        Console.WriteLine("You are not born yet!");
                        return;
                    }
                }
            }
            if (birthday.Month > now.Month)
            {
                Console.WriteLine("You are " + (age - 1) + " years old.");
                Console.WriteLine("After ten years you will be " + (age + 9) + " years old.");
            }
            if (birthday.Month < now.Month)
            {
                Console.WriteLine("You are " + age + " years old.");
                Console.WriteLine("After ten years you will be " + (age + 10) + " years old.");
            }
            if (birthday.Month == now.Month)
            {
                if (birthday.Day > now.Day)
                {
                    Console.WriteLine("You are " + (age - 1) + " years old.");
                    Console.WriteLine("After ten years you will be " + (age + 9) + " years old.");
                }
                if (birthday.Day < now.Day)
                {
                    Console.WriteLine("You are " + age + " years old.");
                    Console.WriteLine("After ten years you will be " + (age + 10) + " years old.");
                }
                else // same like "if (birthday.Day == now.Day)"
                {
                    Console.WriteLine("Happy birthday!");
                    Console.WriteLine("You are " + age + " years old.");
                    Console.WriteLine("After ten years you will be " + (age + 10) + " years old.");
                }
            }
        }
    }
}