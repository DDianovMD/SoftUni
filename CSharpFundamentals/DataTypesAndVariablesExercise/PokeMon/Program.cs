using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionPower = int.Parse(Console.ReadLine());
            int startingPokePower = pokePower;
            int targets = 0;

            while (pokePower >= distance)
            {
                targets++;
                pokePower -= distance;

                if (pokePower == startingPokePower / 2 && exhaustionPower != 0)
                {
                    pokePower /= exhaustionPower;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targets);
        }
    }
}