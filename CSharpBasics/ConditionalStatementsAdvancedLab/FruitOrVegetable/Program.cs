using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        public static void Main()
        {
            string food = Console.ReadLine();

            if (food == "banana")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "tomato")
            {
                Console.WriteLine("vegetable");
            }
            else if (food == "cucumber")
            {
                Console.WriteLine("vegetable");
            }
            else if (food == "pepper")
            {
                Console.WriteLine("vegetable");
            }
            else if (food == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}