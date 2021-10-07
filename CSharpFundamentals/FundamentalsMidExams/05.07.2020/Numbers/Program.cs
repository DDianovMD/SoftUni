using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = userInput.Average();

            for (int i = 0; i < userInput.Count; i++)
            {
                if (userInput[i] <= average)
                {
                    userInput.RemoveAt(i);
                    i--;
                }
            }

            userInput.Sort();
            userInput.Reverse();

            if (userInput.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i > userInput.Count - 1)
                    {
                        break;
                    }
                    Console.Write(userInput[i] + " ");
                }
            }
        }
    }
}
