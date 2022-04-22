using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Where(x => char.IsUpper(x[0]))
                   .ToList()
                   .ForEach(x => Console.WriteLine(x));
        }
    }
}
