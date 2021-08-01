using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbersArray2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < numbersArray1.Length; i++)
            {
                if (numbersArray1[i] != numbersArray2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }
                else
                {
                    sum += numbersArray1[i];
                }
                if (i == numbersArray1.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
            }
        }
    }
}