using System;
using System.Collections.Generic;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            string userInput = string.Empty;
            List<string> names = new List<string>(); // hold all names
            List<string> ages = new List<string>(); // hold age for each person

            string name = string.Empty;
            string age = string.Empty;

            for (int i = 0; i < numberOfInputs; i++)
            {
                userInput = Console.ReadLine();

                for (int j = userInput.IndexOf("@") + 1; j < userInput.IndexOf("|"); j++)
                {
                    name += userInput[j];
                }

                for (int j = userInput.IndexOf("#") + 1; j < userInput.IndexOf("*"); j++)
                {
                    age += userInput[j];
                }

                names.Add(name);
                ages.Add(age);

                name = string.Empty;
                age = string.Empty;
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} is {ages[i]} years old.");
            }
        }
    }
}
