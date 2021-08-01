using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            string trueOrFalse = "";
            for (int i = 1; i <= numbers; i++)
            {
                int sum = 0;
                if (i < 10)
                {
                    sum = i;
                }
                else
                {
                    sum = i / 10 + i % 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    trueOrFalse = "True";
                    Console.WriteLine($"{i} -> {trueOrFalse}");
                }
                else
                {
                    trueOrFalse = "False";
                    Console.WriteLine($"{i} -> {trueOrFalse}");
                }
            }

        }
    }
}