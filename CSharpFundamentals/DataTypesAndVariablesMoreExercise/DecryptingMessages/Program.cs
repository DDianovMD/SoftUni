using System;
using System.Text;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine()); // receiving user's key
            int n = int.Parse(Console.ReadLine()); // number of lines, which will follow
            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char userInput = char.Parse(Console.ReadLine());
                int asciiValue = key + (int)userInput;
                decryptedMessage.Append(Convert.ToChar(asciiValue));
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
