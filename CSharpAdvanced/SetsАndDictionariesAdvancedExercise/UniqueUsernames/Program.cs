using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueUsernames
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();
            StringBuilder userInput = new StringBuilder();

            for (int i = 0; i < numberOfInputs; i++)
            {
                userInput.Append(Console.ReadLine());

                if (names.Contains(userInput.ToString()) == false)
                {
                    names.Add(userInput.ToString());
                }
                
                userInput.Clear();
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
