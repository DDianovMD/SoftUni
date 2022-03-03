using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                if (stackOfNumbers.Count > 0)
                {
                    stackOfNumbers.Pop();
                }
            }

            if (stackOfNumbers.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stackOfNumbers.Contains(commands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stackOfNumbers.Min());
                }
            }
        }
    }
}