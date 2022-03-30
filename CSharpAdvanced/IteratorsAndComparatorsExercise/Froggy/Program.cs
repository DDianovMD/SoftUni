using System;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main()
        {
            var stones = Console.ReadLine().Split(", ").Select(int.Parse);

            Lake<int> lake = new Lake<int>(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
