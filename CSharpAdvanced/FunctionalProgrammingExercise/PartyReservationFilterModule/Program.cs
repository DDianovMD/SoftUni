using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main()
        {
            List<string> invitedPeople = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();

            List<string> filteredPeople = new List<string>();

            string[] command = new string[3];

            while (true)
            {
                command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Print")
                {
                    break;
                }

                if (command[0] == "Add filter")
                {
                    if (command[1] == "Starts with")
                    {
                        foreach (var person in invitedPeople.FindAll(x => x.Substring(0, command[2].Length) == command[2]))
                        {
                            filteredPeople.Add(person);
                            invitedPeople.Remove(person);
                        }                        
                    }
                    else if (command[1] == "Ends with")
                    {
                        foreach (var person in invitedPeople.FindAll(x => x.Substring(x.Length - command[2].Length, command[2].Length) == command[2]))
                        {
                            filteredPeople.Add(person);
                            invitedPeople.Remove(person);
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        foreach (var person in invitedPeople.FindAll(x => x.Length == int.Parse(command[2])))
                        {
                            filteredPeople.Add(person);
                            invitedPeople.Remove(person);
                        }
                    }
                    else if (command[1] == "Contains")
                    {
                        foreach (var person in invitedPeople.FindAll(x => x.Contains(command[2])))
                        {
                            filteredPeople.Add(person);
                            invitedPeople.Remove(person);
                        }
                    }
                }
                else if (command[0] == "Remove filter")
                {
                    if (command[1] == "Starts with")
                    {
                        foreach (var person in filteredPeople.FindAll(x => x.Substring(0, command[2].Length) == command[2]))
                        {
                            filteredPeople.Remove(person);
                            invitedPeople.Add(person);
                        }
                    }
                    else if (command[1] == "Ends with")
                    {
                        foreach (var person in filteredPeople.FindAll(x => x.Substring(x.Length - command[2].Length, command[2].Length) == command[2]))
                        {
                            filteredPeople.Remove(person);
                            invitedPeople.Add(person);
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        foreach (var person in filteredPeople.FindAll(x => x.Length == int.Parse(command[2])))
                        {
                            filteredPeople.Remove(person);
                            invitedPeople.Add(person);
                        }
                    }
                    else if (command[1] == "Contains")
                    {
                        foreach (var person in filteredPeople.FindAll(x => x.Contains(command[2])))
                        {
                            filteredPeople.Remove(person);
                            invitedPeople.Add(person);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", invitedPeople));
        }
    }
}
