using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.Write($"{name}{delimiter}{family}");
        }
    }
}