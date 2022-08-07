using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulator
{
    internal class Program
    {
        static void Main()
        {
            string givenString = Console.ReadLine();

            List<string> command = Console.ReadLine().Split(" ").ToList();

            while (true)
            {
                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Translate")
                {
                    string charToReplace = command[1];
                    string replacementString = command[2];

                    givenString = givenString.Replace(charToReplace, replacementString);
                    Console.WriteLine(givenString);
                }
                else if (command[0] == "Includes")
                {
                    string givenSubstring = command[1];

                    if (givenString.Contains(givenSubstring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "Start")
                {
                    string givenSubstring = command[1];

                    if (givenString.Substring(0, givenSubstring.Length) == givenSubstring)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "Lowercase")
                {
                    givenString = givenString.ToLower();
                    Console.WriteLine(givenString);
                }
                else if (command[0] == "FindIndex")
                {
                    string character = command[1];
                    Console.WriteLine(givenString.LastIndexOf(character));
                }
                else if (command[0] == "Remove")
                {
                    int startIndex = int.Parse(command[1]);
                    int countOfCharsToRemove = int.Parse(command[2]);

                    givenString = givenString.Remove(startIndex, countOfCharsToRemove);
                    Console.WriteLine(givenString);
                }

                command = Console.ReadLine().Split(" ").ToList();
            }
        }
    }
}
