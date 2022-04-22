using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main()
        {
            int[] userInput = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            Console.WriteLine(userInput.Length);
            Console.WriteLine(userInput.Sum());
        }
    }
}
