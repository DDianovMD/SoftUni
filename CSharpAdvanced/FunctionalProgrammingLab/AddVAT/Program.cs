using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split(", ")
                .Select(x => decimal.Parse(x) * (decimal)1.2)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:F2}"));
        }
    }
}
