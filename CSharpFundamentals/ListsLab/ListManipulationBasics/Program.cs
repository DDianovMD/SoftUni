using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command.Contains("add"))
                {
                    numbers.Add(int.Parse((command[command.Length - 1]).ToString()));
                }
                else if (command.Contains("removeat"))
                {
                    numbers.RemoveAt(int.Parse((command[command.Length - 1]).ToString()));
                }
                else if (command.Contains("remove"))
                {
                    numbers.Remove(int.Parse((command[command.Length - 1]).ToString()));
                }
                else if (command.Contains("insert"))
                {
                    numbers.Insert(int.Parse((command[command.Length - 1]).ToString()), int.Parse((command[command.Length - 3]).ToString()));
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}