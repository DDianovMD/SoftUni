using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main()
        {
            MyCustumStackImplementation<string> custumStack = new MyCustumStackImplementation<string>();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                var userInput = command.Split(", ").ToList();

                // Push given items in the custum stack
                if (userInput[0].ToLower().Contains("push"))
                {
                    userInput[0] = userInput[0].Substring(5);
                    custumStack.Push(userInput);
                }
                // Use custum Pop() method to remove last added item in the custum stack
                else if (userInput[0].ToLower() == "pop")
                {
                    custumStack.Pop();
                }

                command = Console.ReadLine();
            }

            // Print twice all elements in custum stack implementation

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in custumStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
