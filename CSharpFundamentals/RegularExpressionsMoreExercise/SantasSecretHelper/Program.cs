using System;
using System.Text.RegularExpressions;

namespace SantasSecretHelper
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());

            string encryptedMessage = Console.ReadLine();

            string decryptedMessage = string.Empty;

            string regexPattern = @"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]+!(?<behavior>[NG])!";

            while (encryptedMessage.ToLower() != "end")
            {                
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    decryptedMessage += (char)((int)encryptedMessage[i] - key);
                }

                if (Regex.IsMatch(decryptedMessage, regexPattern))
                {
                    if (Regex.Match(decryptedMessage, regexPattern).Groups["behavior"].Value == "G")
                    {
                        Console.WriteLine(Regex.Match(decryptedMessage, regexPattern).Groups["name"].Value);
                    }
                }

                decryptedMessage = string.Empty;
                encryptedMessage = Console.ReadLine();
            }
        }
    }
}
