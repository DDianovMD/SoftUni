using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            for (int i = 2; i <= number; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
