using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    counter1 += 1;
                }
                if (number % 3 == 0)
                {
                    counter2 += 1;
                }
                if (number % 4 == 0)
                {
                    counter3 += 1;
                }
            }
            double p1 = counter1 / n * 100;
            double p2 = counter2 / n * 100;
            double p3 = counter3 / n * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}