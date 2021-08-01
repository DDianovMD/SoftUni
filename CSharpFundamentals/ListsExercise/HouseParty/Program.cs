using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>(commandsCount);
            string[] command = new string[2];
            
            for (int i = 0; i < commandsCount; i++)
            {
                command = ReadCommand();
                if (command[1] == "going!")
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else if (command[1] == "not going!")
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        private static string[] ReadCommand()
        {
            return Console.ReadLine()
             .Split(" is ")
             .ToArray();
        }
    }
}
