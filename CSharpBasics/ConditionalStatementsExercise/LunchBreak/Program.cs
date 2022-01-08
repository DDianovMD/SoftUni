using System;

namespace LunchBreak
{
    class Program
    {
        static void Main()
        {
            string episodesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int BreakDuration = int.Parse(Console.ReadLine());

            double timeForLunch = BreakDuration / 8.0;
            double leisureTime = BreakDuration / 4.0;

            double timeLeft = BreakDuration - timeForLunch - leisureTime;

            if (timeLeft >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {episodesName} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {episodesName}, you need {Math.Ceiling(Math.Abs(timeLeft - episodeDuration))} more minutes.");
            }
        }
    }
}
