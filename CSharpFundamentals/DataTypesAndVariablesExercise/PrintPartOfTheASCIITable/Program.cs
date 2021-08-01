using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());

            for (int i = startingChar; i <= lastChar; i++)
            {
                char asciisymbol = (char)i;
                if (i < lastChar)
                {                    
                    Console.Write(asciisymbol + " ");
                }
                else
                {
                    Console.Write(asciisymbol);
                }
            }
        }
    }
}