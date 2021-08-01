using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(userInput[i]);
            }
        }
    }
}