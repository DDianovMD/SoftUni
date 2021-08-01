using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideLength = int.Parse(Console.ReadLine());

            PrintMatrix(sideLength);
        }

        public static void PrintMatrix(int sideLength)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(sideLength + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
