using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            CalculateResult(number, power);
        }
        static void CalculateResult(double a, int b)
        {
            double result = Math.Pow(a, b);
            Console.WriteLine(result);
        }
    }
}
