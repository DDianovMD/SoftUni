using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < number)
            {
                int number2 = int.Parse(Console.ReadLine());
                sum += number2;
            }
            Console.WriteLine(sum);
        }
    }
}