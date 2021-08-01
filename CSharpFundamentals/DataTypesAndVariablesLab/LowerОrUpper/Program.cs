using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());

            if (char.IsUpper(char1))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}