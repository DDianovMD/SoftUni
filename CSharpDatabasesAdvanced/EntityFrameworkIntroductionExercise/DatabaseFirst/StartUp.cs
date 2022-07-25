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
                Console.WriteLine(GetEmployeesWithSalaryOver50000(db));
            }
        }

        //                                 04. Employees with Salary Over 50 000
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
    }
}

//                                         03. Employees Full Information solution

//  public static string GetEmployeesFullInformation(SoftUniContext context)
//  {
//      var sb = new StringBuilder();

//      var result = context.Employees
//         .OrderBy(x => x.EmployeeId)
//         .Select(x => new
//          {
//              firstName = x.FirstName,
//              lastName = x.LastName,
//              middleName = x.MiddleName,
//              jobTitle = x.JobTitle,
//              salary = x.Salary
//          })
//          .ToList();

//      foreach (var employee in result)
//      {
//          sb.Append($"{employee.firstName} {employee.lastName} {employee.middleName} {employee.jobTitle} {employee.salary:F2}")
//            .Append(Environment.NewLine);
//      }

//      return sb.ToString().Trim();
//  }