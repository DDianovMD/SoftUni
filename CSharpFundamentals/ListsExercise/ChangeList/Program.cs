using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commands = new string[3];

            commands = ReadCommand();

            while (commands[0] != "end")
            {
                if (commands[0] == "delete")
                {
                    listOfInts.RemoveAll(n => n == int.Parse(commands[1]));
                }
                else if (commands[0] == "insert")
                {
                    listOfInts.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                commands = ReadCommand();
            }

            Console.WriteLine(string.Join(" ", listOfInts));
        }

        private static string[] ReadCommand()
        {
            return Console.ReadLine().ToLower()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
        }
    }
}
