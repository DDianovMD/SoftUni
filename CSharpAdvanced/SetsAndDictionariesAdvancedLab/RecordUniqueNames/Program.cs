using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
