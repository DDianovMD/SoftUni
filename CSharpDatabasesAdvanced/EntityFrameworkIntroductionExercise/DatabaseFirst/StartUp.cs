using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
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
                Console.WriteLine(GetDepartmentsWithMoreThan5Employees(db));
            }
        }

        //                      10.	Departments with More Than 5 Employees

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                                     .Where(x => x.Employees.Count > 5)
                                     .OrderBy(x => x.Employees.Count)
                                     .ThenBy(x => x.Name)
                                     .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.Name} - {department.Manager.FirstName} {department.Manager.LastName}");

                foreach(var employee in department.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        //                      09. Employee 147

        public static string GetEmployee147(SoftUniContext context)
        {
            var employee = context.Employees
                                  .Include(x => x.EmployeesProjects)
                                  .FirstOrDefault(x => x.EmployeeId == 147);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var employeeProject in employee.EmployeesProjects.OrderBy(x => x.Project.Name))
            {
                Project project = employeeProject.Project;

                sb.AppendLine($"{project.Name}");
            }

            return sb.ToString().TrimEnd();
        }

        //                      08. Addresses by Town

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

        //                      07. Employees and Projects

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employeeProjects = context.EmployeesProjects
                                   .Include(x => x.Project)
                                   .Include(x => x.Employee)
                                   .Where(x => x.Project.StartDate.Year >= 2001 && x.Project.StartDate.Year <= 2003)
                                   .Take(10)
                                   .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employeeProject in employeeProjects)
            {
                Employee employee = employeeProject.Employee;

                sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");

                foreach (var project in employeeProjects.Select(x => x.Project).Where(x => x.ProjectId == employeeProject.ProjectId).ToList())
                {
                    if (project.EndDate != null)
                    {
                        sb.AppendLine($"--{project.Name} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - {project.EndDate?.ToString("M/d/yyyy h:mm:ss tt")}");
                    }
                    else
                    {
                        sb.AppendLine($"--{project.Name} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - not finished");
                    }
                }
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