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

            string[] command = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> usedCommands = new List<string>();
            usedCommands.Add(command[0]);

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "removeat")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "printeven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "printodd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "getsum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (command[0] == "filter")
                {
                    if (command[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(command[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(command[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(command[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(command[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                usedCommands.Add(command[0]);
            }

            if (usedCommands.Contains("add") || usedCommands.Contains("removeat") || usedCommands.Contains("remove") || usedCommands.Contains("insert"))
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}