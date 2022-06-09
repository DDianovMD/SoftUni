using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToList();

            int inputsCount = 0;

            while (true)
            {
                string[] userInput = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();

                if (userInput[0].ToLower() == "end")
                {
                    break;
                }

                inputsCount++;

                int firstIndex = int.Parse(userInput[0]);
                int secondIndex = int.Parse(userInput[1]);

                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= elements.Count || secondIndex < 0 || secondIndex >= elements.Count)
                {
                    int middleIndex = elements.Count / 2;
                    elements.Insert(middleIndex, $"-{inputsCount}a");
                    elements.Insert(middleIndex + 1, $"-{inputsCount}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        string elementToRemove = elements[firstIndex];
                        elements.Remove(elementToRemove);
                        elements.Remove(elementToRemove);
                        Console.WriteLine($"Congrats! You have found matching elements - {elementToRemove}!");

                        if (elements.Count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

            }

            if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {inputsCount} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
