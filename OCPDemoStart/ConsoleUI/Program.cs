//using NotOCPLibrary;
//using NotOCPLibrary.Types;
using OCPLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            WrongSolution();

            Console.ReadLine();
        }

        private static void WrongSolution()
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new PersonModel { FirstName = "Sue", LastName = "Storm", EmployeeType = EmployeeType.Manager },
                new PersonModel { FirstName = "Nancy", LastName = "Roman", EmployeeType = EmployeeType.Executive }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }
        }
    }
}
