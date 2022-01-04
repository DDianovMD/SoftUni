using System;

namespace DigitsLettersАndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                string tempString = string.Empty;

                if (i == 0)
                {
                    for (int j = 0; j < userInput.Length; j++)
                    {
                        if (char.IsDigit(userInput[j]))
                        {
                            tempString += userInput[j];
                        }
                        
                        if (j == userInput.Length - 1)
                        {
                            Console.WriteLine(tempString);
                        }
                    }
                }
                else if (i == 1)
                {
                    for (int j = 0; j < userInput.Length; j++)
                    {
                        if (char.IsLetter(userInput[j]))
                        {
                            tempString += userInput[j];
                        }

                        if (j == userInput.Length - 1)
                        {
                            Console.WriteLine(tempString);
                        }
                    }
                }
                else if (i == 2)
                {
                    for (int j = 0; j < userInput.Length; j++)
                    {
                        if (char.IsLetterOrDigit(userInput[j]) == false)
                        {
                            tempString += userInput[j];
                        }

                        if (j == userInput.Length - 1)
                        {
                            Console.WriteLine(tempString);
                        }
                    }
                }
            }
        }
    }
}
