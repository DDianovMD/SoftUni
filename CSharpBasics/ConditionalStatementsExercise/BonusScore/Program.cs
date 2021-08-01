using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine()); // начално число
            double bonusPoints; // бонус точки
            if (startingNumber <= 100)
            {
                bonusPoints = 5;
                if (startingNumber % 2 == 0)
                {
                    bonusPoints = bonusPoints + 1;
                }
                if (startingNumber % 5 == 0 && startingNumber % 10 != 0)
                {
                    bonusPoints = bonusPoints + 2;
                }
                double finalPoints = startingNumber + bonusPoints;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(finalPoints);
            }
            if (startingNumber > 100 && startingNumber < 1000)
            {
                bonusPoints = startingNumber * 0.2;
                if (startingNumber % 2 == 0)
                {
                    bonusPoints = bonusPoints + 1;
                }
                if (startingNumber % 5 == 0 && startingNumber % 10 != 0)
                {
                    bonusPoints = bonusPoints + 2;
                }
                double finalPoints = startingNumber + bonusPoints;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(finalPoints);
            }
            if (startingNumber > 1000)
            {
                bonusPoints = startingNumber * 0.10;
                if (startingNumber % 2 == 0)
                {
                    bonusPoints = bonusPoints + 1;
                }
                if (startingNumber % 5 == 0 && startingNumber % 10 != 0)
                {
                    bonusPoints = bonusPoints + 2;
                }
                double finalPoints = startingNumber + bonusPoints;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(finalPoints);
            }
        }
    }
}