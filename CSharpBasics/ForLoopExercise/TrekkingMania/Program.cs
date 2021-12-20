using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
		{
			int numberOfGroups = int.Parse(Console.ReadLine());
			int people = 0;
			int MusalaGroup = 0;
			int MonblanGroup = 0;
			int KilimanjaroGroup = 0;
			int K2Group = 0;
			int EverestGroup = 0;
			int currentGroup;

			for (int i = 0; i < numberOfGroups; i++)
			{
				currentGroup = int.Parse(Console.ReadLine());
				people += currentGroup;

				if (currentGroup <= 5)
				{
					MusalaGroup += currentGroup;
				}
				else if (currentGroup > 5 && currentGroup <= 12)
				{
					MonblanGroup += currentGroup;
				}
				else if (currentGroup > 12 && currentGroup <= 25)
				{
					KilimanjaroGroup += currentGroup;
				}
				else if (currentGroup > 25 && currentGroup <= 40)
				{
					K2Group += currentGroup;
				}
				else
				{
					EverestGroup += currentGroup;
				}

			}

			Console.WriteLine($"{MusalaGroup / (double)people * 100:F2}%");
			Console.WriteLine($"{MonblanGroup / (double)people * 100:F2}%");
			Console.WriteLine($"{KilimanjaroGroup / (double)people * 100:F2}%");
			Console.WriteLine($"{K2Group / (double)people * 100:F2}%");
			Console.WriteLine($"{EverestGroup / (double)people * 100:F2}%");

		}
	}
}
