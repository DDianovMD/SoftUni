using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = Console.ReadLine();
            double total = 0;
            while (sum != "NoMoreMoney")
            {
                if (double.Parse(sum) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {double.Parse(sum):F2}");
                total += double.Parse(sum);
                sum = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}