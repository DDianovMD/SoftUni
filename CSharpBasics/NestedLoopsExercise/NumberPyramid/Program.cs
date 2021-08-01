using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{num} ");
                    num++;
                    if (num > n)
                    {
                        Environment.Exit(0);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}