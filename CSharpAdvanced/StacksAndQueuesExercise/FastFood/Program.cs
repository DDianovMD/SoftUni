using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>();

            foreach (var order in orders)
            {
                ordersQueue.Enqueue(order);
            }

            Console.WriteLine(ordersQueue.Max());

            for (int i = 0; i < ordersQueue.Count; i++)
            {
                if (foodQuantity - ordersQueue.Peek() >= 0)
                {
                    foodQuantity -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                    i--;
                }
                else
                {
                    break;
                }
            }

            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");

                for (int i = 0; i < ordersQueue.Count; i++)
                {                    
                    if (i < ordersQueue.Count - 1)
                    {
                        Console.Write($"{ordersQueue.Peek()} ");
                        ordersQueue.Dequeue();
                        i--;
                    }
                    else
                    {
                        Console.Write($"{ordersQueue.Peek()}");
                        ordersQueue.Dequeue();
                        i--;
                    }                    
                }
            }
        }
    }
}
