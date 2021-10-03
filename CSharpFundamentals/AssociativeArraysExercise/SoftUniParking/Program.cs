using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (command[0].ToLower() == "register")
                {
                    if (registeredUsers.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredUsers[command[1]]}");
                    }
                    else
                    {
                        registeredUsers.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0].ToLower() == "unregister")
                {
                    if (registeredUsers.ContainsKey(command[1]))
                    {
                        registeredUsers.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
