using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> intQueue = new Queue<int>();

            foreach (var number in userInput)
            {
                intQueue.Enqueue(number);
            }

            for (int i = 0; i < userInput.Length; i++)
            {
                

                if (intQueue.Peek() % 2 == 0 && i < userInput.Length - 1)
                {
                    Console.Write($"{intQueue.Peek()}, ");                    
                }
                else if (intQueue.Peek() % 2 == 0 && i == userInput.Length - 1)
                {
                    Console.WriteLine(intQueue.Peek());                    
                }
                intQueue.Dequeue();
            }
        }
    }
}
