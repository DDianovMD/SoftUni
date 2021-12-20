using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
		{
			double savings = double.Parse(Console.ReadLine());
			double drumPrice;

			List<int> initialDrumsQuality = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			List<int> currentDrumsQuality = new List<int>();

			for (int i = 0; i < initialDrumsQuality.Count; i++)
			{
				currentDrumsQuality.Add(initialDrumsQuality[i]);
			}

			string command = ReceiveCommand();

			while (command != "Hit it again, Gabsy!")
			{
				// Hitting the drums
				for (int i = 0; i < currentDrumsQuality.Count; i++)
				{
					currentDrumsQuality[i] -= int.Parse(command);
				}

				// Check if drum is broken.
				for (int i = 0; i < initialDrumsQuality.Count; i++)
				{

					if (currentDrumsQuality[i] <= 0) // If it is broken.
					{
						drumPrice = initialDrumsQuality[i] * 3.00; // Calculate drum price.

						// Check if she has enough money to buy new drum.
						if (savings - drumPrice >= 0) // If she can afford new drum.
						{
							currentDrumsQuality[i] = initialDrumsQuality[i];
							savings -= drumPrice;
						}
						else // Else if she can't afford new drum.
						{
							currentDrumsQuality.RemoveAt(i);
							initialDrumsQuality.RemoveAt(i);
							i--;
						}
					}
				}

				command = ReceiveCommand();
			}

			// Print result
			for (int i = 0; i < currentDrumsQuality.Count; i++)
			{
				if (i < currentDrumsQuality.Count - 1)
				{
					Console.Write($"{currentDrumsQuality[i]} ");
				}
				else
				{
					Console.WriteLine($"{currentDrumsQuality[i]}");
				}
			}

			Console.WriteLine($"Gabsy has {savings:F2}lv.");
		}

		// Methods
		private static string ReceiveCommand()
		{
			return Console.ReadLine();
		}
	}
}
