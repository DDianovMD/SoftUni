using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            PrintUpperPart(row);
            PrintLowerPart(row);
            Console.ReadLine();
        }
        static void PrintUpperPart(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void PrintLowerPart(int row)
        {
            for (int i = row - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
