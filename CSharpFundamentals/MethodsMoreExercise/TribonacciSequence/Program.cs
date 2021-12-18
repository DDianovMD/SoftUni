using System;
using System.Collections.Generic;

namespace TribonacciSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int givenNumber = int.Parse(Console.ReadLine());
			List<int> TribonacciSequence = new List<int>();

			// Fill the TribonacciSequence
			for (int i = 0; i < givenNumber; i++)
			{
				if (i == 0)
				{
					TribonacciSequence.Add(1);
				}
				else if (i == 1)
				{
					TribonacciSequence.Add(1);
				}
				else if (i == 2)
				{
					TribonacciSequence.Add(2);
				}
				else
				{
					int nextNumber = TribonacciSequence[i - 1] + TribonacciSequence[i - 2] + TribonacciSequence[i - 3];
					TribonacciSequence.Add(nextNumber);
				}
			}

			// Print result
			for (int i = 0; i < TribonacciSequence.Count; i++)
			{
				if (i != TribonacciSequence.Count - 1)
				{
					Console.Write($"{TribonacciSequence[i]} ");
				}
				else
				{
					Console.Write($"{TribonacciSequence[i]}");
				}
			}

		}
	}
}