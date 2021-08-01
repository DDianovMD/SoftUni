using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building

{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i > 0; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floors)
                    {
                        if (j != (rooms - 1))
                        {
                            Console.Write($"L{i}{j} ");
                        }
                        else
                        {
                            Console.WriteLine($"L{i}{j}");
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        if (j != (rooms - 1))
                        {
                            Console.Write($"O{i}{j} ");
                        }
                        else
                        {
                            Console.WriteLine($"O{i}{j}");
                        }
                    }
                    else
                    {
                        if (j != (rooms - 1))
                        {
                            Console.Write($"A{i}{j} ");
                        }
                        else
                        {
                            Console.WriteLine($"A{i}{j}");
                        }
                    }
                }
            }
        }
    }
}