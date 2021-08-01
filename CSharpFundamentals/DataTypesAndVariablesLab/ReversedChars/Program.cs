using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            Console.Write($"{char3} {char2} {char1}");
        }
    }
}