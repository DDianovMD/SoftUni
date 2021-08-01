using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.Write($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}