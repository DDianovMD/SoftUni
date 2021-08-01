using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers

{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinaionsCounter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinaionsCounter += 1;
                    if ((i + j) == magicNumber)
                    {
                        int result = i + j;
                        Console.WriteLine($"Combination N:{combinaionsCounter} ({i} + {j} = {result})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{combinaionsCounter} combinations - neither equals {magicNumber}");
        }
    }
}