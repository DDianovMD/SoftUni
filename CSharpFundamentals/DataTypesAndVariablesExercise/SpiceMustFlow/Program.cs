using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int sum = 0;

            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    days++;
                    sum = sum + (startingYield - 26);
                    startingYield -= 10;
                }
                sum -= 26;              

                Console.WriteLine(days);
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(sum);
            }
        }
    }
}