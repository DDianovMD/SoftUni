using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            StringBuilder encryptedInput = new StringBuilder();

            for (int i = 0; i < userInput.Length; i++)
            {
                int charASCIIcode = (int)userInput[i];

                int charEncrypting = charASCIIcode + 3;
                
                encryptedInput.Append(((char)charEncrypting).ToString());
            }

            Console.WriteLine(encryptedInput);
        }
    }
}
