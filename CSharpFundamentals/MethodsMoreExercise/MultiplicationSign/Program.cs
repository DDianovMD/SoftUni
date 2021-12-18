using System;

namespace MultiplicationSign
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] givenNumbers = new int[3];

			for (int i = 0; i < givenNumbers.Length; i++)
			{
				givenNumbers[i] = int.Parse(Console.ReadLine());
				if (givenNumbers[i] == 0)
				{
					Console.WriteLine("zero");
					Environment.Exit(0);
				}
			}

			int negativeNumbersCount = 0;

			foreach (var num in givenNumbers)
			{
				if (num < 0)
				{
					negativeNumbersCount++;
				}
			}

			if (negativeNumbersCount % 2 == 0 || negativeNumbersCount == 0)
			{
				Console.WriteLine("positive");
			}
			else
			{
				Console.WriteLine("negative");
			}

		}
	}
}