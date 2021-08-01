using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int deduction = 0;

            for (int i = 1; i <= numberOfTabs; i++)
            {
                string siteName = Console.ReadLine();
                if (siteName == "Facebook")
                {
                    deduction += 150;
                    if ((salary - deduction) <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                else if (siteName == "Instagram")
                {
                    deduction += 100;
                    if ((salary - deduction) <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                else if (siteName == "Reddit")
                {
                    deduction += 50;
                    if ((salary - deduction) <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
            }
            if ((salary - deduction) > 0)
            {
                Console.WriteLine(salary - deduction);
            }
        }
    }
}