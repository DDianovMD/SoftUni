using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == -0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i] + " => " + (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}