using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main()
        {           
            int numberOfInputs = int.Parse(Console.ReadLine());

            StringBuilder currentText = new StringBuilder();
            Stack<string> addedText = new Stack<string>();
            Stack<string> removedText = new Stack<string>();
            Stack<int> commandsLog = new Stack<int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var userInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (userInput[0] == "1")
                {
                    currentText.Append(userInput[1]);
                    addedText.Push(userInput[1]);
                    commandsLog.Push(int.Parse(userInput[0]));
                }
                else if (userInput[0] == "2")
                {
                    string textToRemove = currentText.ToString().Substring(currentText.Length - int.Parse(userInput[1]), int.Parse(userInput[1]));
                    currentText.Remove(currentText.Length - int.Parse(userInput[1]), int.Parse(userInput[1]));
                    removedText.Push(textToRemove);
                    commandsLog.Push(int.Parse(userInput[0]));
                }
                else if (userInput[0] == "3")
                {
                    for (int j = 0; j < currentText.Length; j++)
                    {
                        if (j == int.Parse(userInput[1]) - 1)
                        {
                            Console.WriteLine(currentText[j]);
                        }
                    }
                }
                else if (userInput[0] == "4")
                {
                    if (commandsLog.Count > 0)
                    {
                        if (commandsLog.Pop() == 1)
                        {
                            string modifiedText = currentText.ToString().Substring(0, currentText.Length - addedText.Pop().Length);
                            currentText.Clear();
                            currentText.Append(modifiedText);
                        }
                        else
                        {
                            currentText.Append(removedText.Pop());
                        }
                    }
                }
            }
        }
    }
}
