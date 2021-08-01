using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] train = new int[wagonsCount];
            for (int i = 0; i < wagonsCount; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var item in train)
            {
                Console.Write(item + " ");
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
