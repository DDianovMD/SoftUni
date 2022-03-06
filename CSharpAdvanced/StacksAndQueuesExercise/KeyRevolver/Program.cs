using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            int[] bulletsArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locksArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>();

            foreach (var bullet in bulletsArray)
            {
                bulletsStack.Push(bullet);
            }

            Queue<int> locksQueue = new Queue<int>();

            foreach (var item in locksArray)
            {
                locksQueue.Enqueue(item);
            }

            int usedBulletsCounter = 0;

            while (locksQueue.Count > 0 && bulletsStack.Count > 0)
            {
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                    usedBulletsCounter++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletsStack.Pop();
                    usedBulletsCounter++;
                }

                if (bulletsStack.Count > 0 && usedBulletsCounter == barrelSize)
                {
                    Console.WriteLine("Reloading!");
                    usedBulletsCounter = 0;
                }
            }

            if (bulletsStack.Count == 0 && locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else if (bulletsStack.Count >= 0 && locksQueue.Count == 0)
            {
                int bulletsCost = (bulletsArray.Length - bulletsStack.Count) * bulletPrice;
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligenceValue - bulletsCost}");
            }
        }
    }
}
