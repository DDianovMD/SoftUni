using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            bool isTrue = true;
            string[] commands = new string[2];
            commands = ReadCommand();

            while (isTrue)
            {

                if (commands[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", wagons));
                    isTrue = false;
                    break;
                }

                if (commands[0] == "add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(commands[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(commands[0]);
                            break;
                        }
                    }
                }

                commands = ReadCommand();
            }
        }

        private static string[] ReadCommand()
        {
            return Console.ReadLine().ToLower()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
        }
    }
}
