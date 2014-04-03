using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            string firstName = "Dimitar";
            string middleName = "Todorov";
            string lastName = "Sinemorski";
            decimal bankBalance = 300.00m;
            string bankName = "Postbank";
            string IBAN = "BG48BPBI79401064525602";
            long firstCreditCard = 5294858501556944;
            long secondCreditCard = 9932466871654985;
            long thirdCreditCard = 4853211584452416;

            Console.WriteLine("Bank account:");
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Middle name: " + middleName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Your money balance: " + bankBalance);
            Console.WriteLine("Bank name: " + bankName);
            Console.WriteLine("IBAN: " + IBAN);
            Console.WriteLine("Credit cards numbers:");
            Console.WriteLine("First: {0}\nSecond: {1}\nThird: {2}", firstCreditCard, secondCreditCard, thirdCreditCard);
        }
    }
}
/*A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account using the 
 * appropriate data types and descriptive names.*/