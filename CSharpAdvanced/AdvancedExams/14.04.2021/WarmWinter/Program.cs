using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    public class Program
    {
        public static void Main()
        {
            // Read input info
            int[] hatsInfo = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int[] scarfsInfo = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            // Used variables
            Stack<int> hatsStack = new Stack<int>(hatsInfo);
            Queue<int> scarfsQueue = new Queue<int>(scarfsInfo);
            Queue<int> sets = new Queue<int>();

            // Program logic
            while (hatsStack.Count > 0 && scarfsQueue.Count > 0)
            {
                int currentHat = hatsStack.Pop();
                int currentScarf = scarfsQueue.Peek();

                if (currentHat < currentScarf && hatsStack.Count > 0)
                {
                    currentHat = hatsStack.Pop();
                }

                if (currentHat > currentScarf)
                {
                    sets.Enqueue(currentHat + currentScarf);
                    scarfsQueue.Dequeue();
                }
                else if (currentHat == currentScarf)
                {
                    currentHat += 1;
                    hatsStack.Push(currentHat);
                    scarfsQueue.Dequeue();
                }
            }

            // Print output
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
