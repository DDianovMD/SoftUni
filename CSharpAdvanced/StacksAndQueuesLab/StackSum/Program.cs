using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> intStack = new Stack<int>();

            foreach (var number in integers)
            {
                intStack.Push(number);
            }

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)                
                .ToArray();

            while (commands[0].ToLower() != "end")
            {
                if (commands[0].ToLower() == "add")
                {
                    intStack.Push(int.Parse(commands[1]));
                    intStack.Push(int.Parse(commands[2]));
                }
                else if (commands[0].ToLower() == "remove")
                {
                    if (int.Parse(commands[1]) <= intStack.Count)
                    {
                        for (int i = 0; i < int.Parse(commands[1]); i++)
                        {
                            intStack.Pop();
                        }
                    }
                }

                commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine("Sum: " + intStack.Sum());
        }
    }
}
