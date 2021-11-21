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

            //If stack is not empty:
            if (stackOfNumbers.Count != 0)
            {
                int smallestNumberInStack = int.MaxValue;
                bool printSmallestNumber = true;

                for (int i = 0; i < stackOfNumbers.Count; i++)
                {
                    // If number is presented in the stack -> print "true".
                    if (commands[2] == stackOfNumbers.Peek())
                    {
                        Console.WriteLine("true");
                        printSmallestNumber = false;
                        break;
                    }
                    // If number is not presented in the stack -> remember smallest number.
                    else
                    {
                        if (stackOfNumbers.Peek() <= smallestNumberInStack)
                        {
                            smallestNumberInStack = stackOfNumbers.Peek();
                            stackOfNumbers.Pop();
                            i--;
                        }
                    }
                }

                // Print smallest number.
                if (printSmallestNumber == true)
                {
                    Console.WriteLine(smallestNumberInStack);
                }
            }
            // If stack is empty -> print 0
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}