using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main()
        {
            int neededSum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            Func<int, string, bool> checkName = (x, y) =>
            {
                int sum = 0;

                foreach (var letter in y)
                {
                    sum += (int)letter;
                }

                if (sum >= x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int i = 0; i < names.Length; i++)
            {
                if (checkName(neededSum, names[i]))
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }
    }
}
