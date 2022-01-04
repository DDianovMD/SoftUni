using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToBeRemoved = Console.ReadLine();
            string text = Console.ReadLine();

            
            while (true)
            {
                if (text.IndexOf(textToBeRemoved) != -1)
                {
                    text = text.Remove(text.IndexOf($"{textToBeRemoved}"), textToBeRemoved.Length);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{text}");
        }
    }
}
