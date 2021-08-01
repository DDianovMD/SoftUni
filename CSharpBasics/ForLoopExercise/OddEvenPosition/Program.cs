using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0.00;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.00;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    if (i % 2 == 1)
                    {
                        if (number < oddMin)
                        {
                            oddMin = number;
                        }
                        if (number > oddMax)
                        {
                            oddMax = number;
                        }
                        oddSum += number;
                    }
                    Console.WriteLine($"OddSum={oddSum:F2},");
                    Console.WriteLine($"OddMin={oddMin:F2},");
                    Console.WriteLine($"OddMax={oddMax:F2},");
                    Console.WriteLine($"EvenSum={evenSum:F2},");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    if (i % 2 == 1)
                    {
                        if (number < oddMin)
                        {
                            oddMin = number;
                        }
                        if (number > oddMax)
                        {
                            oddMax = number;
                        }
                        oddSum += number;
                    }
                    else
                    {
                        if (number < evenMin)
                        {
                            evenMin = number;
                        }
                        if (number > evenMax)
                        {
                            evenMax = number;
                        }
                        evenSum += number;
                    }
                }
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
