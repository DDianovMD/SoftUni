using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main()
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double totalWater = waterPerDay * numberOfPlayers * numberOfDays;
            double foodPerDay = double.Parse(Console.ReadLine());
            double totalFood = foodPerDay * numberOfPlayers * numberOfDays;

            for (int i = 1; i <= numberOfDays; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                groupEnergy -= energyLost;

                if (groupEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    totalWater -= totalWater * 0.3;
                }

                if (i % 3 == 0)
                {
                    totalFood -= totalFood / numberOfPlayers;
                    groupEnergy += groupEnergy * 0.1;
                }
            }

            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
            }
        }
    }
}
