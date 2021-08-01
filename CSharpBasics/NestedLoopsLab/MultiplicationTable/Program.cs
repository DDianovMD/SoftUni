using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable

{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    Console.WriteLine($"{a} * {b} = {(a * b)}");
                }
            }
        }
    }
}