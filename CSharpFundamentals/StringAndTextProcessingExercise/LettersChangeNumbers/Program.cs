using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            decimal sum = 0;

            for (int i = 0; i < userInput.Count; i++)
            {
                char[] currentStringAsChars = userInput[i].ToCharArray();

                char letterBeforeNumber = char.MinValue;
                decimal letterBeforeNumberIndex = decimal.MinValue;

                char letterAfterNumber = char.MinValue;
                decimal letterAfterNumberIndex = decimal.MinValue;

                string currentNumber = string.Empty;

                for (int j = 1; j < currentStringAsChars.Length; j++)
                {
                    if (char.IsDigit(currentStringAsChars[j]))
                    {
                        if (char.IsLetter(currentStringAsChars[j - 1]))
                        {
                            letterBeforeNumber = currentStringAsChars[j - 1];
                            letterBeforeNumberIndex = j - 1;
                        }
                        if (char.IsLetter(currentStringAsChars[j + 1]))
                        {
                            letterAfterNumber = currentStringAsChars[j + 1];
                            letterAfterNumberIndex = j + 1;
                        }
                    }

                    if (letterBeforeNumberIndex != decimal.MinValue && letterAfterNumberIndex != decimal.MinValue)
                    {
                        for (int k = (int)letterBeforeNumberIndex + 1; k < letterAfterNumberIndex; k++)
                        {
                            currentNumber += currentStringAsChars[k];
                        }
                    }

                    if (currentNumber != string.Empty)
                    {
                        decimal result = 0;

                        if ((int)letterBeforeNumber >= 65 && (int)letterBeforeNumber <= 90) // => letter is uppercase => we must divide the number by the letter's position in the alphabet.
                        {
                            decimal letterPositionInAlphabet = "abcdefghijklmnopqrstuvwxyz".IndexOf(letterBeforeNumber.ToString().ToLower()) + 1;

                            result = decimal.Parse(currentNumber) / letterPositionInAlphabet;

                        }
                        else if ((int)letterBeforeNumber >= 97 && (int)letterBeforeNumber <= 122) // => letter is lowercase => we must multiply the number with the letter's position in the alphabet.
                        {
                            decimal letterPositionInAlphabet = "abcdefghijklmnopqrstuvwxyz".IndexOf(letterBeforeNumber.ToString().ToLower()) + 1;

                            result = decimal.Parse(currentNumber) * letterPositionInAlphabet;
                        }

                        if ((int)letterAfterNumber >= 65 && (int)letterAfterNumber <= 90) // => letter is uppercase => we must subtract its position from the resulted number.
                        {
                            decimal letterPositionInAlphabet = "abcdefghijklmnopqrstuvwxyz".IndexOf(letterAfterNumber.ToString().ToLower()) + 1;

                            result -= letterPositionInAlphabet;
                        }
                        else if ((int)letterAfterNumber >= 97 && (int)letterAfterNumber <= 122) // => letter is lowercase => we must add its position to the resulted number.
                        {
                            decimal letterPositionInAlphabet = "abcdefghijklmnopqrstuvwxyz".IndexOf(letterAfterNumber.ToString().ToLower()) + 1;

                            result += letterPositionInAlphabet;
                        }

                        sum += result;

                        letterBeforeNumber = char.MinValue;
                        letterBeforeNumberIndex = decimal.MinValue;
                        
                        letterAfterNumber = char.MinValue;
                        letterAfterNumberIndex = decimal.MinValue;
                        
                        currentNumber = string.Empty;
                    }
                }
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
