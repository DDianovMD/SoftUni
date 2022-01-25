using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string keyPattern = @"([sS]|[tT]|[aA]|[rR])";
            string planetPattern = @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(?<attackType>[A|D])![^@\-!:>]*->(\d+)";

            List<string> encryptedMessages = new List<string>();
            List<string> decryptedMessages = new List<string>();
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            
            // Read encrypted messages
            for (int i = 0; i < numberOfMessages; i++)
            {
                encryptedMessages.Add(Console.ReadLine());
            }

            // Decrypt each message
            foreach (string message in encryptedMessages)
            {
                int key = Regex.Matches(message, keyPattern).Count;
                string currentMessage = string.Empty;

                for (int i = 0; i < message.Length; i++)
                {
                    int unicode = (int)message[i] - key;
                    currentMessage += (char)unicode;
                }

                decryptedMessages.Add(currentMessage);
            }

            // Extract attacked and destroyed planets
            foreach (string message in decryptedMessages)
            {
                if (Regex.IsMatch(message, planetPattern))
                {
                    Match match = Regex.Match(message, planetPattern);
                    
                    if (match.Groups["attackType"].Value == "A")
                    {
                        attackedPlanets.Add(match.Groups["planetName"].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(match.Groups["planetName"].Value);
                    }
                }
            }

            // Sort lists alphabetically
            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            // Print output
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            for (int i = 0; i < attackedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {attackedPlanets[i]}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            for (int i = 0; i < destroyedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {destroyedPlanets[i]}");
            }
        }
    }
}
