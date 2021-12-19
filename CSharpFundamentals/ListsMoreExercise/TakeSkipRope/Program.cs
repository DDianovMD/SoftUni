using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> encryptedText = Console.ReadLine() // Read user input.
                .ToList();

            List<int> numbersFromText = new List<int>(); // Used to separate numbers.

            StringBuilder decryptedText = new StringBuilder(); // Used to build decrypted message.

            int currentEncryptedTextIndex = 0; // Used to track current index of taken/skipped characters from encrypted message.

            // Check every character if it's a number and remove it from text in another List<int>.
            for (int i = 0; i < encryptedText.Count; i++)
            {
                if (int.TryParse(encryptedText[i].ToString(), out int num))
                {
                    numbersFromText.Add(int.Parse(encryptedText[i].ToString()));
                    encryptedText.RemoveAt(i);
                    i--;
                }
            }

            // Iterate over encryptedMessage by taking and skipping characters
            for (int i = 0; i < numbersFromText.Count; i++)
            {
                if (i % 2 == 0) // => TakeList
                {
                    for (int j = numbersFromText[i]; j > 0; j--) // Take numbersFromText[i] characters from encryptedText.
                    {
                        if (currentEncryptedTextIndex < encryptedText.Count) // Check if needed character index is in range.
                        {
                            decryptedText.Append(encryptedText[currentEncryptedTextIndex]);
                            currentEncryptedTextIndex++;
                        }
                    }
                }
                else // => SkipList
                {
                    currentEncryptedTextIndex += numbersFromText[i]; // Skip numbersFromText[i] characters from encryptedText.
                }
            }

            // Print Result.
            Console.WriteLine(decryptedText);
        }
    }
}
