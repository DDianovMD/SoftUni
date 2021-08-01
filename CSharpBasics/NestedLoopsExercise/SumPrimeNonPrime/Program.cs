using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime

{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int primeSum = 0;
            int nonPrimeSum = 0;
            bool isTrue = true;

            while (isTrue)
            {
                command = Console.ReadLine();
                int number = 0;
                if (command != "stop")
                {
                    number = int.Parse(command);
                }
                else
                {
                    isTrue = false;
                    break;
                }

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if ((number % 2 == 0 && number != 2) || (number % 3 == 0 && number != 3))
                {
                    nonPrimeSum += number;
                }
                else
                {
                    primeSum += number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}