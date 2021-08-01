using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commands = new string[3];
            commands = ReceiveCommand();

            while (commands[0] != "end")
            {
                if (commands[0] == "add")
                {
                    listOfIntegers.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "insert")
                {
                    if (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) >= listOfIntegers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfIntegers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "remove")
                {
                    if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) >= listOfIntegers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfIntegers.RemoveAt(int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "shift")
                {
                    int num;

                    if (commands[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            num = listOfIntegers[0];
                            listOfIntegers.RemoveAt(0);
                            listOfIntegers.Add(num);
                        }
                    }
                    else if (commands[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            num = listOfIntegers[listOfIntegers.Count - 1];
                            listOfIntegers.RemoveAt(listOfIntegers.Count - 1);
                            listOfIntegers.Insert(0, num);
                        }
                    }
                }

                commands = ReceiveCommand();
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }

        private static string[] ReceiveCommand()
        {
            return Console.ReadLine().ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}
