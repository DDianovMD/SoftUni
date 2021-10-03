using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (isTrue)
            {
                string[] command = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "End")
                {
                    isTrue = false;
                    break;
                }
                else
                {
                    if (companies.ContainsKey(command[0]) == false)
                    {
                        companies.Add(command[0], new List<string> { command[1] });
                    }
                    else
                    {
                        if (companies[command[0]].Contains(command[1]) == false)
                        {
                            companies[command[0]].Add(command[1]);
                        }                        
                    }
                }
            }

            foreach (var company in companies.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{company.Key}");
                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}
