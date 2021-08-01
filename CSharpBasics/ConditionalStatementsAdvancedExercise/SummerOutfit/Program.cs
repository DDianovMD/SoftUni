using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        public static void Main()
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (dayTime == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (dayTime == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
            }
            else if (degrees >= 25)
            {
                if (dayTime == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
            }
        }
    }
}