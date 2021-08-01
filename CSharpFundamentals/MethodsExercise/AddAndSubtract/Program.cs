using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sumResult = Sum(firstNum, secondNum);
            int finalResult = Subtract(sumResult, thirdNum);

            Console.WriteLine(finalResult);
        }

        private static int Subtract(int sumResult, int thirdNum)
        {
            return sumResult - thirdNum;
        }

        public static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
