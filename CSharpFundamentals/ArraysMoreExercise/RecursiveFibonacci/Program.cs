using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            int[] FibonacciSequence = new int[userInput];

            for (int i = 0; i < FibonacciSequence.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    FibonacciSequence[i] = 1;
                }
                else
                {
                    FibonacciSequence[i] = FibonacciSequence[i - 1] + FibonacciSequence[i - 2];
                }
            }

            Console.WriteLine(FibonacciSequence[FibonacciSequence.Length - 1]);
        }
    }
}
