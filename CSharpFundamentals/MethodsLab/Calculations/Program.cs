using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToUpper();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (command == "ADD")
            {
                Add(num1, num2);
            }
            else if (command == "MULTIPLY")
            {
                Multiply(num1, num2);
            }
            else if (command == "SUBTRACT")
            {
                Subtract(num1, num2);
            }
            else if (command == "DIVIDE")
            {
                Divide(num1, num2);
            }
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
