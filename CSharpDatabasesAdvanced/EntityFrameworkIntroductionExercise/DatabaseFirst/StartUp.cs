using System;
using System.Linq;
using System.Text;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new SoftUniContext())
            {
                Console.WriteLine(GetAddressesByTown(db));
            }
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var adresses = context.Addresses
                                  .OrderByDescending(x => x.Employees.Count)
                                  .ThenBy(x => x.Town.Name)
                                  .ThenBy(x => x.AddressText)
                                  .Take(10)
                                  .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var adress in adresses)
            {
                sb.AppendLine($"{adress.AddressText}, {adress.Town.Name} - {adress.Employees.Count} employees");
            }

            return sb.ToString().TrimEnd();
        }

        //                      06. Adding a New Address and Updating Employee

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var newAddress = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(newAddress);
            context.Employees.First(x => x.LastName == "Nakov").Address = newAddress;

            context.SaveChanges();

            var result = context.Employees
                                .OrderByDescending(x => x.Address.AddressId)
                                .Take(10)
                                .Select(x => x.Address.AddressText)
                                .ToList();

            foreach (var address in result)
            {
                sb.AppendLine(address);
            }

            return sb.ToString().Trim();
        }

        //                      05.Employees from Research and Development

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context.Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    departmentName = x.Department.Name,
                    salary = x.Salary
                })
                .ToList();

            foreach (var employee in result)
            {
                sb.Append($"{employee.firstName} {employee.lastName} from {employee.departmentName} - ${employee.salary:F2}")
                  .Append(Environment.NewLine);
            }

            return sb.ToString().Trim();
        }

        //                      04.Employees with Salary Over 50 000

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context.Employees
               .Where(x => x.Salary > 50000)
               .OrderBy(x => x.FirstName)
               .Select(x => new
               {
                   firstName = x.FirstName,
                   salary = x.Salary
               })
               .ToList();

            foreach (var employee in result)
            {
                sb.Append($"{employee.firstName} - {employee.salary:F2}")
                  .Append(Environment.NewLine);
            }

            return sb.ToString().Trim();
        }

        //                      03.Employees Full Information solution

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context.Employees
               .OrderBy(x => x.EmployeeId)
               .Select(x => new
               {
                   firstName = x.FirstName,
                   lastName = x.LastName,
                   middleName = x.MiddleName,
                   jobTitle = x.JobTitle,
                   salary = x.Salary
               })
                .ToList();

            foreach (var employee in result)
            {
                sb.Append($"{employee.firstName} {employee.lastName} {employee.middleName} {employee.jobTitle} {employee.salary:F2}")
                  .Append(Environment.NewLine);
            }

            return sb.ToString().Trim();
        }
    }
}