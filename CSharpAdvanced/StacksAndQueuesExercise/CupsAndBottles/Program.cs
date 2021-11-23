using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottlesCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cupsQueue = new Queue<int>();

            foreach (var cup in cupsCapacity)
            {
                cupsQueue.Enqueue(cup);
            }

            Stack<int> bottlesStack = new Stack<int>();

            foreach (var bottle in bottlesCapacity)
            {
                bottlesStack.Push(bottle);
            }

            int currentCup = cupsQueue.Peek();
            int currentBottle = bottlesStack.Peek();
            int wastedWater = 0;

            while (cupsQueue.Count >= 1 && bottlesStack.Count >= 1)
            {
                if (currentCup - currentBottle == 0)
                {
                    cupsQueue.Dequeue();
                    if (cupsQueue.Count > 0)
                    {
                        currentCup = cupsQueue.Peek();
                    }                    
                    bottlesStack.Pop();
                    if (bottlesStack.Count > 0)
                    {
                        currentBottle = bottlesStack.Peek();
                    }                    
                }
                else if (currentCup - currentBottle < 0)
                {
                    cupsQueue.Dequeue();
                    wastedWater += Math.Abs(currentCup - currentBottle);
                    if (cupsQueue.Count > 0)
                    {
                        currentCup = cupsQueue.Peek();
                    }                    
                    bottlesStack.Pop();
                    if (bottlesStack.Count > 0)
                    {
                        currentBottle = bottlesStack.Peek();
                    }
                }
                else if (currentCup - currentBottle > 0)
                {
                    currentCup = currentCup - currentBottle;
                    bottlesStack.Pop();
                    if (bottlesStack.Count > 0)
                    {
                        currentBottle = bottlesStack.Peek();
                    }
                }
            }

            if (bottlesStack.Count == 0)
            {
                Console.Write("Cups: ");
                foreach (var cup in cupsQueue)
                {
                    Console.Write($"{cup} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (cupsQueue.Count == 0)
            {
                Console.Write("Bottles: ");
                foreach (var bottle in bottlesStack)
                {
                    Console.Write($"{bottle} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
