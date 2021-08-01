using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int positiveNumber = Math.Abs(int.Parse(userInput));
            int length = positiveNumber.ToString().Length;
            string positiveString = positiveNumber.ToString();
            int sumOfEvenDigits = GetSumOfEvenDigits(positiveString, length);
            int sumOfOddDigits = GetSumOfOddDigits(positiveString, length);
            int result = GetMultipleOfEvenAndOdds(sumOfEvenDigits, sumOfOddDigits);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(string positiveNumber, int length)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (int.Parse(positiveNumber[i].ToString()) % 2 == 0)
                {
                    sum += int.Parse(positiveNumber[i].ToString());
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(string positiveNumber, int length)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (int.Parse(positiveNumber[i].ToString()) % 2 != 0)
                {
                    sum += int.Parse(positiveNumber[i].ToString());
                }
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
