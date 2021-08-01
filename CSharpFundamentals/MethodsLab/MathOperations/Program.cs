using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string numbersOperator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            double result = NumbersOperating(firstNum, secondNum, numbersOperator);
            Console.WriteLine(result);
        }
        static double NumbersOperating(double num1, double num2, string numbersOperator)
        {
            double result = 0;
            if (numbersOperator == "+")
            {
                result = num1 + num2;
            }
            else if (numbersOperator == "-")
            {
                result = num1 - num2;
            }
            else if (numbersOperator == "/")
            {
                result = num1 / num2;
            }
            else if (numbersOperator == "*")
            {
                result = num1 * num2;
            }
            return Math.Round(result, 2);
        }
    }
}
