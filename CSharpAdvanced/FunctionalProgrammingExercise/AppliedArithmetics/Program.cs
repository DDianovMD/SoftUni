using System;
using System.Linq;
using System.Text;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            StringBuilder command = new StringBuilder();

            while (true)
            {
                command.Append(Console.ReadLine());

                if (command.ToString().ToLower() == "end")
                {
                    break;
                }

                if (command.ToString().ToLower() == "add")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] += 1;
                    }
                }
                else if (command.ToString().ToLower() == "multiply")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] *= 2;
                    }
                }
                else if (command.ToString().ToLower() == "subtract")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                else if (command.ToString().ToLower() == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                command.Clear();
            }
        }
    }
}
