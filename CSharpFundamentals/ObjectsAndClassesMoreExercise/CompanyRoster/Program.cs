using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Employee
    {
        public string name { get; set; }
        public decimal salary { get; set; }
        public string department { get; set; }

        public Employee(string name, decimal salary, string department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            SortedDictionary<string, decimal> averageSalaries = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                Employee currentEmployee = new Employee(userInput[0], decimal.Parse(userInput[1]), userInput[2]);
                employees.Add(currentEmployee);

                // Add departments as keys in SortedDictionary with default value 0
                if (averageSalaries.Keys.Contains(userInput[2]) == false)
                {
                    averageSalaries.Add(userInput[2], 0);
                }
            }

            // Calculate average salary
            for (int i = 0; i < averageSalaries.Keys.Count; i++)
            {
                int peopleInDepartment = 0;
                decimal sumOfSalaries = 0;

                for (int j = 0; j < employees.Count; j++)
                {
                    if (employees.ElementAt(j).department == averageSalaries.Keys.ElementAt(i))
                    {
                        peopleInDepartment++;
                        sumOfSalaries += employees.ElementAt(j).salary;
                    }

                    // Set average salary for each department (key)
                    if (peopleInDepartment > 0)
                    {
                        averageSalaries[averageSalaries.Keys.ElementAt(i)] = sumOfSalaries / peopleInDepartment;
                    }                    
                }
            }            

            Console.WriteLine($"Highest Average Salary: {averageSalaries.OrderByDescending(x => x.Value).ElementAt(0).Key}");

            foreach (var human in employees.Where(x => x.department == averageSalaries.OrderByDescending(x => x.Value).ElementAt(0).Key).OrderByDescending(x => x.salary))
            {
                Console.WriteLine($"{human.name} {human.salary:F2}");
            }
        }
    }
}
