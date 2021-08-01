using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        public static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result;

            if (symbol == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - even");
                }
                else
                    Console.WriteLine($"{num1} + {num2} = {result} - odd");
            }
            else if (symbol == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - even");
                }
                else
                    Console.WriteLine($"{num1} - {num2} = {result} - odd");
            }
            else if (symbol == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - even");
                }
                else
                    Console.WriteLine($"{num1} * {num2} = {result} - odd");
            }
            else if (symbol == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, result);
                }
            }
            else if (symbol == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
        }
    }
}