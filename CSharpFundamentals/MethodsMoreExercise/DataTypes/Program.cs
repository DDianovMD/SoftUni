using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputType = Console.ReadLine();

            if (userInputType.ToLower() == "int")
            {
                ReadInputAndPrintResult(int.Parse(Console.ReadLine()));
            }
            else if (userInputType.ToLower() == "real")
            {
                ReadInputAndPrintResult(double.Parse(Console.ReadLine()));
            }
            else if (userInputType.ToLower() == "string")
            {
                ReadInputAndPrintResult(Console.ReadLine());
            }
        }

        public static void ReadInputAndPrintResult(string text)
        {
            Console.WriteLine($"${text}$");
        }

        public static void ReadInputAndPrintResult(double number)
        {
            Console.WriteLine($"{number * 1.5:F2}");
        }

        public static void ReadInputAndPrintResult(int number)
        {
            Console.WriteLine(number * 2);
        }
    }
}
