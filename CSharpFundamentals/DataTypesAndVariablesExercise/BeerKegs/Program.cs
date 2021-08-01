using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBeerKegs = int.Parse(Console.ReadLine());
            string biggestModel = String.Empty;
            double radius = 0.0;
            int hight = 0;
            double biggestVolume = int.MinValue;

            for (int i = 0; i < numberOfBeerKegs; i++)
            {
                string model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                hight = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * radius * radius * (double)hight;
                if (currentVolume > biggestVolume)
                {
                    biggestVolume = currentVolume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}