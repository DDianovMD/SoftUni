using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            string[] userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in userInput)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}
