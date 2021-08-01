using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().ToLower();
            VowelsCounter(userInput);
        }
        static void VowelsCounter(string text)
        {
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == "a" || text[i].ToString() == "i" || text[i].ToString() == "o" || text[i].ToString() == "u" || text[i].ToString() == "e")
                {
                    sum += 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
