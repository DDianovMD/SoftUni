using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
		{
			int numberOfTournaments = int.Parse(Console.ReadLine());
			int allPoints = int.Parse(Console.ReadLine());
			int wonPoints = 0;
			int wonTournaments = 0;

			for (int i = 0; i < numberOfTournaments; i++)
			{
				string result = Console.ReadLine();
				if (result == "W")
				{
					allPoints += 2000;
					wonPoints += 2000;
					wonTournaments++;
				}
				else if (result == "F")
				{
					allPoints += 1200;
					wonPoints += 1200;
				}
				else if (result == "SF")
				{
					allPoints += 720;
					wonPoints += 720;
				}
			}

			Console.WriteLine($"Final points: {allPoints}");
			Console.WriteLine($"Average points: {wonPoints / numberOfTournaments}");
			Console.WriteLine($"{(double)wonTournaments / numberOfTournaments * 100:F2}%");
		}
	}
}
