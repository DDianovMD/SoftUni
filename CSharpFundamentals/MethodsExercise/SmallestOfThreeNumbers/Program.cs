using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            EvaluateNumbers(number1, number2, number3);
        }
        static void EvaluateNumbers(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine(num3);
            }
            else if (num1 == num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 == num3 && num2 < num1)
            {
                Console.WriteLine(num2);
            }
            else if (num1 == num3 && num1 < num2)
            {
                Console.WriteLine(num1);
            }
            else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine(num1);
            }
        }
    }
}
