using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> key = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> encryptedMessages = new List<string>();
            List<string> decryptedMessages = new List<string>();

            string decryptedMessage = string.Empty;

            bool keepGoing = true;

            while (keepGoing)
            {
                string userInput = Console.ReadLine();

                if (userInput == "find")
                {
                    keepGoing = false;
                    break;
                }

                encryptedMessages.Add(userInput);
                userInput = string.Empty;
            }

            foreach (var message in encryptedMessages)
            {
                int j = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    decryptedMessage += (char)((int)message[i] - key[j]);

                    if (j == key.Count - 1)
                    {
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                decryptedMessages.Add(decryptedMessage);
                decryptedMessage = string.Empty;
            }

            string type = string.Empty;
            string coordinates = string.Empty;

            foreach (var message in decryptedMessages)
            {
                type = message.Split("&", StringSplitOptions.RemoveEmptyEntries).ToList()[1];

                for (int i = message.IndexOf("<") + 1; i < message.IndexOf(">"); i++)
                {
                    coordinates += message[i];
                }

                Console.WriteLine($"Found {type} at {coordinates}");
                coordinates = string.Empty;
            }
        }
    }
}
