using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        static void Main()
        {
            List<string> partyPeople = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

            List<string> command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();

            while (true)
            {
                if (command[0] == "Party!")
                {
                    break;
                }

                if (command[0].ToLower() == "double")
                {
                    if (command[1].ToLower() == "startswith")
                    {
                        for (int i = 0; i < partyPeople.Count; i++)
                        {
                            if (partyPeople[i].Substring(0, command[2].Length) == command[2])
                            {
                                partyPeople.Insert(i + 1, partyPeople[i]);
                                i++;
                            }
                        }
                    }
                    else if (command[1].ToLower() == "endswith")
                    {
                        for (int i = 0; i < partyPeople.Count; i++)
                        {
                            if (partyPeople[i].Substring(partyPeople[i].Length - command[2].Length, command[2].Length) == command[2])
                            {
                                partyPeople.Insert(i + 1, partyPeople[i]);
                                i++;
                            }
                        }
                    }
                    else if (command[1].ToLower() == "length")
                    {
                        for (int i = 0; i < partyPeople.Count; i++)
                        {
                            if (partyPeople[i].Length == int.Parse(command[2]))
                            {
                                partyPeople.Insert(i + 1, partyPeople[i]);
                                i++;
                            }
                        }
                    }
                }
                else if (command[0].ToLower() == "remove")
                {
                    if (command[1].ToLower() == "startswith")
                    {
                        for (int i = 0; i < partyPeople.Count; i++)
                        {
                            if (partyPeople[i].Substring(0, command[2].Length) == command[2])
                            {
                                partyPeople.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (command[1].ToLower() == "endswith")
                    {
                        for (int i = 0; i < partyPeople.Count; i++)
                        {
                            if (partyPeople[i].Substring(partyPeople[i].Length - command[2].Length, command[2].Length) == command[2])
                            {
                                partyPeople.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (command[1].ToLower() == "length")
                    {
                        for (int i = 0; i < partyPeople.Count; i++)
                        {
                            if (partyPeople[i].Length == int.Parse(command[2]))
                            {
                                partyPeople.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();
            }

            if (partyPeople.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", partyPeople));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
