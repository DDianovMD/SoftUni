using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
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

            Queue<int> numbersQueue = new Queue<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                numbersQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                if (numbersQueue.Count > 0)
                {
                    numbersQueue.Dequeue();
                }                
            }

            if (numbersQueue.Count > 0)
            {
                int smallestNumberInQueue = int.MaxValue;
                bool printSmallestNumber = true;

                for (int i = 0; i < numbersQueue.Count; i++)
                {
                    if (commands[2] == numbersQueue.Peek())
                    {
                        Console.WriteLine("true");
                        printSmallestNumber = false;
                        break;                    
                    }
                    else
                    {
                        if (numbersQueue.Peek() <= smallestNumberInQueue)
                        {
                            smallestNumberInQueue = numbersQueue.Peek();
                            numbersQueue.Dequeue();
                            i--;
                        }
                    }
                }

                if (printSmallestNumber == true)
                {
                    Console.WriteLine(smallestNumberInQueue);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
