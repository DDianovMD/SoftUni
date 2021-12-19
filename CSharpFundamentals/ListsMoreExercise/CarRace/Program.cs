using System;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] racingTrace = Console.ReadLine() // One Judge test fails when calculating with decimal instead double.
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            // Calculating left racer time
            for (int i = 0; i < racingTrace.Length / 2; i++)
            {
                if (racingTrace[i] == 0)
                {
                    leftRacerTime *= 0.8;
                }
                else
                {
                    leftRacerTime += racingTrace[i];
                }
            }

            // Calculating right racer time
            for (int i = racingTrace.Length - 1; i > racingTrace.Length / 2; i--)
            {
                if (racingTrace[i] == 0)
                {
                    rightRacerTime *= 0.8;
                }
                else
                {
                    rightRacerTime += racingTrace[i];
                }
            }

            // Print winner            
            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }            
        }
    }
}
