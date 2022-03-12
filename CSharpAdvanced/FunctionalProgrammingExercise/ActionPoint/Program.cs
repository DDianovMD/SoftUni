using System;
using System.Linq;

namespace ActionPoint
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
                Console.WriteLine(item);
            }
        }
    }
}
