using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ProgrammingFundamentalsCourse = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = new string[3];

            command = ReceiveCommand();

            while (command[0].ToLower() != "course start")
            {
                if (command[0].ToLower() == "add")
                {
                    if (ProgrammingFundamentalsCourse.Contains(command[1]) == false)
                    {
                        ProgrammingFundamentalsCourse.Add(command[1]);
                    }
                }
                else if (command[0].ToLower() == "insert")
                {
                    if (ProgrammingFundamentalsCourse.Contains(command[1]) == false)
                    {
                        ProgrammingFundamentalsCourse.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0].ToLower() == "remove")
                {
                    if (ProgrammingFundamentalsCourse.Contains(command[1]) == true)
                    {
                        ProgrammingFundamentalsCourse.Remove(command[1]);
                    }
                    if (ProgrammingFundamentalsCourse.Contains($"{command[1]}-Exercise") == true)
                    {
                        ProgrammingFundamentalsCourse.Remove($"{command[1]}-Exercise");
                    }
                }
                else if (command[0].ToLower() == "swap")
                {
                    if (ProgrammingFundamentalsCourse.Contains(command[1]) == true &&
                        ProgrammingFundamentalsCourse.Contains(command[2]) == true)
                    {
                        int firstLectureIndex = ProgrammingFundamentalsCourse.IndexOf(command[1]);
                        int secondLectureIndex = ProgrammingFundamentalsCourse.IndexOf(command[2]);

                        ProgrammingFundamentalsCourse.Remove(command[1]);
                        ProgrammingFundamentalsCourse.Remove(command[2]);
                        
                        if (firstLectureIndex > secondLectureIndex)
                        {
                            ProgrammingFundamentalsCourse.Insert(secondLectureIndex, command[1]);
                            ProgrammingFundamentalsCourse.Insert(firstLectureIndex, command[2]);
                        }
                        else if (firstLectureIndex < secondLectureIndex)
                        {
                            ProgrammingFundamentalsCourse.Insert(firstLectureIndex, command[2]);
                            ProgrammingFundamentalsCourse.Insert(secondLectureIndex, command[1]);
                            
                        }                        

                        if (ProgrammingFundamentalsCourse.Contains($"{command[1]}-Exercise") == true)
                        {
                            ProgrammingFundamentalsCourse.Remove($"{command[1]}-Exercise");
                            ProgrammingFundamentalsCourse.Insert(ProgrammingFundamentalsCourse.IndexOf(command[1]) + 1, $"{command[1]}-Exercise");
                        }

                        if (ProgrammingFundamentalsCourse.Contains($"{command[2]}-Exercise") == true)
                        {
                            ProgrammingFundamentalsCourse.Remove($"{command[2]}-Exercise");
                            ProgrammingFundamentalsCourse.Insert(ProgrammingFundamentalsCourse.IndexOf(command[2]) + 1, $"{command[2]}-Exercise");
                        }

                    }
                }
                else if (command[0].ToLower() == "exercise")
                {
                    if (ProgrammingFundamentalsCourse.Contains(command[1]) == true &&
                        ProgrammingFundamentalsCourse.Contains($"{command[1]}-Exercise") == false)
                    {
                        ProgrammingFundamentalsCourse.Insert(ProgrammingFundamentalsCourse.IndexOf(command[1]) + 1, $"{command[1]}-Exercise");
                    }
                    else if (ProgrammingFundamentalsCourse.Contains(command[1]) == false)
                    {
                        ProgrammingFundamentalsCourse.Add(command[1]);
                        ProgrammingFundamentalsCourse.Add($"{command[1]}-Exercise");
                    }
                }
                command = ReceiveCommand();
            }

            for (int i = 0; i < ProgrammingFundamentalsCourse.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ProgrammingFundamentalsCourse[i]}");
            }
        }

        private static string[] ReceiveCommand()
        {
            return Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
        }
    }
}
