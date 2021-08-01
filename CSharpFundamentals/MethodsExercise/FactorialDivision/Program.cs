using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double firstFactorial = CalculateFirstNumFactorial(firstNum);
            double secondFactorial = CalculateSecondNumFactorial(secondNum);

            Console.WriteLine($"{firstFactorial / secondFactorial:F2}");
        }

        private static double CalculateSecondNumFactorial(int userInput)
        {
            double result = 0;
            if (userInput == 0 || userInput == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i < userInput; i++)
                {
                    if (i == 1)
                    {
                        result = result + (i * (i + 1));
                    }
                    else
                    {
                        result *= (i + 1);
                    }
                }
                return result;
            }
        }

        private static double CalculateFirstNumFactorial(int userInput)
        {
            double result = 0;
            if (userInput == 0 || userInput == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i < userInput; i++)
                {
                    if (i == 1)
                    {
                        result = result + (i * (i + 1));
                    }
                    else
                    {
                        result *= (i + 1);
                    }
                }
                return result;
            }
        }
    }
}
