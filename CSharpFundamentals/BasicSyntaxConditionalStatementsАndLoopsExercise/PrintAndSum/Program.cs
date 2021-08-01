using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = number1; i <= number2; i++)
            {
                if (i == number2)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.Write($"{i} ");
                }
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}