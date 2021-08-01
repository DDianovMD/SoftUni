using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNumber = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}