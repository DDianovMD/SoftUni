using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            RepeatTimes(text, times);
        }
        static void RepeatTimes (string text, int times)
        {
            string concatString = string.Empty;
            for (int i = 0; i < times; i++)
            {
                concatString += text;
            }
            Console.WriteLine(concatString);
        }
    }
}
