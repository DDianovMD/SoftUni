using System;

namespace Shopping
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());

            int videoCardsCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double videoCardPrice = 250;
            double videoCardSum = videoCardsCount * videoCardPrice;
            double cpuPrice = videoCardSum * 0.35;
            double ramPrice = videoCardSum * 0.1;

            double cpuSum = cpuCount * cpuPrice;
            double ramSum = ramCount * ramPrice;

            double totalSum = videoCardSum + cpuSum + ramSum;

            if (videoCardsCount > cpuCount)
            {
                totalSum *= 0.85;
            }

            double neededSum = Math.Abs(budget - totalSum);
            double budgetLeft = budget - totalSum;

            if (budget < totalSum)
            {
                Console.WriteLine($"Not enough money! You need {neededSum:f2} leva more!");
            }
            else
            {
                Console.WriteLine($"You have {budgetLeft:f2} leva left!");
            }
        }
    }
}
