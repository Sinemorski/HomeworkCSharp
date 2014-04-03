using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Dimitar";
            string lastName = "Sinemorski";
            byte age = 28;
            char gender = 'm'; 
            long ID = 8506112507;
            int employeeNomber = 27560002;
            Console.WriteLine("Employee Data" + 
                "\nFirst name: {0}" + 
                "\nLast name: {1}" + 
                "\nAge: {2}" + 
                "\nGender: {3}" + 
                "\nPersonal ID number: {4}" + 
                "\nUnique employee number: {5} ", firstName, lastName, age, gender, ID, employeeNomber);
        }
    }
}