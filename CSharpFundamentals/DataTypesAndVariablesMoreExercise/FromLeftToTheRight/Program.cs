using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                string leftNumber = input.Substring(0, input.IndexOf(" "));
                string rightNumber = input.Substring(input.IndexOf(" ") + 1);

                BigInteger firstNumbr = BigInteger.Parse(leftNumber);
                BigInteger secondNumber = BigInteger.Parse(rightNumber);

                if (firstNumbr > secondNumber)
                {
                    sum += firstNumbr % 10;
                    firstNumbr = firstNumbr / 10;
                }
                else
                {
                    sum += secondNumber % 10;
                    firstNumbr = secondNumber / 10;
                }

                Console.WriteLine(sum);
                sum = 0;
            }   
        }
    }
}