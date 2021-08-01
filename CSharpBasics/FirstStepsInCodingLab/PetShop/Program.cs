using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogsNumber = int.Parse(Console.ReadLine());
            var otherAnimals = int.Parse(Console.ReadLine());
            double dogsFoodPrice = dogsNumber * 2.50;
            double otherAnimalsFoodPrice = otherAnimals * 4.00;
            double summedPrice = dogsFoodPrice + otherAnimalsFoodPrice;
            Console.WriteLine("{0} lv.", summedPrice);
        }
    }
}