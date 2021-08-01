using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = ReceiveCommand();

            string temporaryString = string.Empty;

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < userInput.Count)
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (i < userInput.Count)
                            {
                                temporaryString += userInput[i];
                            }
                        }

                        userInput.Insert(startIndex, temporaryString);

                        for (int i = 0; i < endIndex - startIndex; i++)
                        {
                            userInput.RemoveAt(startIndex + 1);
                        }

                        temporaryString = string.Empty;
                    }

                }

                command = ReceiveCommand();
            }

            Console.WriteLine(string.Join(" ", userInput));
        }

        private static string[] ReceiveCommand()
        {
            return Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}
