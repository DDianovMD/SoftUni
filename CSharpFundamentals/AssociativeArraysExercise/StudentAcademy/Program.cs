using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = new string[2];
                command[0] = Console.ReadLine();
                command[1] = Console.ReadLine();

                if (students.ContainsKey(command[0]) == false)
                {
                    students.Add(command[0], new List<double> { double.Parse(command[1]) });
                }
                else
                {
                    students[command[0]].Add(double.Parse(command[1]));
                }
            }

            foreach (var student in students)
            {
                if (student.Value.Average() < 4.50)
                {
                    students.Remove(student.Key);
                }
            }

            foreach (var student in students.OrderByDescending(n => n.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
