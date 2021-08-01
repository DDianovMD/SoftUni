using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int pourTimes = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < pourTimes; i++)
            {
                int pouredLiters = int.Parse(Console.ReadLine());
                sum += pouredLiters;
                if (sum > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= pouredLiters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}