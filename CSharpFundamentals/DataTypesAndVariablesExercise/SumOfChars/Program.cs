using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfChars; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}