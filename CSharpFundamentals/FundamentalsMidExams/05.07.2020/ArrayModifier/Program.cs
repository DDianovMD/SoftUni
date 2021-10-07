using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] userCommands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (userCommands[0].ToLower() != "end")
            {
                if (userCommands[0].ToLower() == "swap")
                {
                    int temp = myArray[int.Parse(userCommands[1])];
                    myArray[int.Parse(userCommands[1])] = myArray[int.Parse(userCommands[2])];
                    myArray[int.Parse(userCommands[2])] = temp;

                }
                else if (userCommands[0].ToLower() == "multiply")
                {
                    int result = myArray[int.Parse(userCommands[1])] * myArray[int.Parse(userCommands[2])];
                    myArray[int.Parse(userCommands[1])] = result;
                }
                else if (userCommands[0].ToLower() == "decrease")
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        int tempNumber = myArray[i];
                        myArray[i] = tempNumber - 1;

                    }
                }

                userCommands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine(string.Join(", ", myArray));
        }
    }
}
