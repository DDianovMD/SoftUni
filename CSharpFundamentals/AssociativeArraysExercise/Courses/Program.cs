using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (isTrue)
            {
                string[] command = Console.ReadLine()
                   .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                if (command[0].ToLower() == "end")
                {
                    isTrue = false;
                    break;
                }
                else
                {
                    if (courses.ContainsKey(command[0]) == false)
                    {
                        courses.Add(command[0], new List<string> { command[1] });
                    }
                    else
                    {
                        courses[command[0]].Add(command[1]);
                    }
                }
            }
            
            foreach (var course in courses.OrderByDescending(n => n.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                List<string> usersList = course.Value.ToList();
                usersList.Sort();
                
                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"-- {usersList[i]}");
                }
            }
        }
    }
}
