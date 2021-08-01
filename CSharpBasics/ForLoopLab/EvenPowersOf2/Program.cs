using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 2;
            Console.WriteLine(Math.Pow(num, 0));
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(num, i));
                }
            }
        }
    }
}