using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = command[0];
                decimal grade = decimal.Parse(command[1]);

                if (students.ContainsKey(name) == false)
                {
                    students.Add(name, new List<decimal> { grade });
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(x => x.ToString("F2")))} (avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
