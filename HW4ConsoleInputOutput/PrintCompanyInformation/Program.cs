using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information about the company:");
            Console.Write("Enter name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneCompany = Console.ReadLine();
            Console.Write("Enter fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Enter web site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine("Now enter information about manager of the company:");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            string age = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneManager = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Information about the company");
            Console.WriteLine("Name: {0}", companyName);
            Console.WriteLine("Adress: {0}", companyAddress);
            Console.WriteLine("Phone number: {0}", phoneCompany);
            Console.WriteLine("Fax: {0}", fax);
            Console.WriteLine("Web site: {0}", webSite);

            Console.WriteLine();
            Console.WriteLine("Information about the manager");
            Console.WriteLine("First name: {0}" + "\nLast name: {1}" + "\nAge: {2}" + "\nPhone number: {3}",
            firstName, lastName, age, phoneManager);
        }
    }
}
