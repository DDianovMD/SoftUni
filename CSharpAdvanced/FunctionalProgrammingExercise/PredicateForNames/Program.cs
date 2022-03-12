using System;

namespace PredicateForNames
{
    class Program
    {
        static void Main()
        {
            int nameLength = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= nameLength)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
