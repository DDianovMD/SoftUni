using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            int ascii1 = (int)char1;
            int ascii2 = (int)char2;

            PrintCharactersInRange(ascii1, ascii2);

        }
        static void PrintCharactersInRange(int ascii1, int ascii2)
        {
            if (ascii1 < ascii2)
            {
                for (int i = ascii1 + 1; i < ascii2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else if (ascii1 > ascii2)
            {
                for (int i = ascii2 + 1; i < ascii1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
