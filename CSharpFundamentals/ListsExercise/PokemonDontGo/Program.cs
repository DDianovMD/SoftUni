using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedItemsSum = 0;

            while (userInput.Count > 0) // looping while there aren't any Pokemons left.
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < userInput.Count)
                {
                    for (int i = 0; i <= index; i++)
                    {
                        if (i == index)
                        {
                            int currentElementValue = userInput[i];
                            removedItemsSum += currentElementValue;
                            userInput.RemoveAt(i);

                            if (userInput.Count == 0)
                            {
                                break;
                            }

                            for (int j = 0; j < userInput.Count; j++)
                            {
                                if (userInput[j] <= currentElementValue)
                                {
                                    userInput[j] = userInput[j] + currentElementValue;
                                }
                                else
                                {
                                    userInput[j] = userInput[j] - currentElementValue;
                                }
                            }
                        }
                    }
                }
                else if (index < 0)
                {
                    int currentElementValue = userInput[0];
                    removedItemsSum += currentElementValue;
                    userInput.RemoveAt(0);

                    if (userInput.Count == 0)
                    {
                        break;
                    }

                    userInput.Insert(0, userInput[userInput.Count - 1]);

                    for (int j = 0; j < userInput.Count; j++)
                    {
                        if (userInput[j] <= currentElementValue)
                        {
                            userInput[j] = userInput[j] + currentElementValue;
                        }
                        else
                        {
                            userInput[j] = userInput[j] - currentElementValue;
                        }
                    }
                }
                else if (index > userInput.Count - 1)
                {
                    int currentElementValue = userInput[userInput.Count - 1];
                    removedItemsSum += currentElementValue;
                    userInput.RemoveAt(userInput.Count - 1);

                    if (userInput.Count == 0)
                    {
                        break;
                    }

                    userInput.Add(userInput[0]);

                    for (int j = 0; j < userInput.Count; j++)
                    {
                        if (userInput[j] <= currentElementValue)
                        {
                            userInput[j] = userInput[j] + currentElementValue;
                        }
                        else
                        {
                            userInput[j] = userInput[j] - currentElementValue;
                        }
                    }
                }
            }

            Console.WriteLine(removedItemsSum);
        }
    }
}
