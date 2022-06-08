using System;

namespace ComputerStore
{
    class Program
    {
        static void Main()
        {
            double totalPriceWithoutTaxes = 0;
            string command = Console.ReadLine();

            while (true)
            {                

                if (command == "special" || command == "regular")
                {
                    break;
                }

                if (double.Parse(command) < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceWithoutTaxes += double.Parse(command);
                }

                command = Console.ReadLine();
            }

            double taxes = totalPriceWithoutTaxes * 0.2;
            double discount = 0;
            double totalPrice = 0;

            if (command == "special")
            {
                discount = (totalPriceWithoutTaxes + taxes) * 0.1;
                totalPrice = totalPriceWithoutTaxes + taxes - discount;
            }
            else
            {
                totalPrice = totalPriceWithoutTaxes + taxes;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }
        }
    }
}
