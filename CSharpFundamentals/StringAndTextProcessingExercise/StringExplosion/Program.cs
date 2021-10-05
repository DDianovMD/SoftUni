using System;
using System.Collections.Generic;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            List<string> splittedInput = new List<string>(userInput.Length);

            int strength = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                splittedInput.Add(userInput[i].ToString());
            }

            for (int i = 0; i < splittedInput.Count - 1; i++)
            {
                if (splittedInput[i] == ">")
                {
                    strength += int.Parse(splittedInput[i + 1]);
                }
                if (strength > 0 && i == splittedInput.Count - 1)
                {
                    strength = 0;
                }

                while (strength > 0 && i != splittedInput.Count - 1)
                {
                    if (splittedInput[i + 1] != ">")
                    {
                        splittedInput.RemoveAt(i + 1);
                        strength--;
                    }
                    else
                    {
                        strength += int.Parse(splittedInput[i + 2]);
                        i++;
                    }
                }
            }

            foreach (var item in splittedInput)
            {
                Console.Write(item);
            }
        }
    }
}
