using System;

namespace TopNumber
{

    class Program
    {
        static void Main(string[] args)
        {          
            string number = Console.ReadLine();
            for (int i = 1; i < int.Parse(number); i++)
            {
                bool isHoldingOddDigit = false;
                int sum = SumCalculator(i.ToString());               
                if (sum % 8 == 0 && sum != 0)
                {
                    int oddDigitsCount = DigitsChecker(i.ToString());
                    if (oddDigitsCount >= 1)
                    {
                        isHoldingOddDigit = true;
                    }
                    else
                    {
                        isHoldingOddDigit = false;
                    }
                }

                if (isHoldingOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int DigitsChecker(string num)
        {
            int oddDigitsCounter = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i].ToString()) % 2 != 0)
                {
                    oddDigitsCounter++;
                }
            }
            return oddDigitsCounter;
        }

        public static int SumCalculator(string num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int number = int.Parse(num[i].ToString());
                sum += number; 
            }
            return sum;
        }
    }
}
