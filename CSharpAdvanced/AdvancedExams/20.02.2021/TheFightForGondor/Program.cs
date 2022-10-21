using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    public class Program
    {
        public static void Main()
        {
            // Read input and initialize used variables
            int numberOfWaves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine()
                                                                .Split()
                                                                .Select(int.Parse));

            Stack<int> orcs = new Stack<int>();


            // Program logic
            for (int wave = 1; wave <= numberOfWaves; wave++)
            {

                int[] orcsWave = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();

                if (plates.Count == 0)
                {
                    break;
                }

                if (wave % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                foreach (int orc in orcsWave)
                {
                    orcs.Push(orc);
                }

                while (plates.Count > 0 && orcs.Count > 0)
                {
                    int currentPlate = plates.Dequeue();
                    int currentOrc = orcs.Pop();

                    if (currentOrc > currentPlate)
                    {
                        orcs.Push(currentOrc -= currentPlate);
                    }
                    else if (currentPlate > currentOrc)
                    {
                        currentPlate -= currentOrc;

                        List<int> temp = new List<int>(plates);
                        temp.Insert(0, currentPlate);
                        plates.Clear();

                        foreach (int plate in temp)
                        {
                            plates.Enqueue(plate);
                        }
                    }
                }
            }

            // Print output
            if (plates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.Write("Orcs left: ");
                Console.WriteLine(string.Join(", ", orcs));
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.Write("Plates left: ");
                Console.WriteLine(string.Join(", ", plates));
            }
        }
    }
}
