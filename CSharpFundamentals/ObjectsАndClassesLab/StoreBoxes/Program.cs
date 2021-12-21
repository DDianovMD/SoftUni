using System;
using System.Collections.Generic;
using System.Linq;


namespace StoreBoxes
{
    public class Item
    {
        public string name { get; set; }
        public double itemPrice { get; set; }

        public Item(string name, double price)
        {
            this.name = name;
            this.itemPrice = price;
        }
    }

    public class Box
    {
        public int serialNumber { get; set; }
        public Item item { get; set; }
        public int itemQuantity { get; set; }
        public double boxPrice { get; set; }

        public Box(int serialNumber, string itemName, int itemQuantity, double itemPrice)
        {
            this.serialNumber = serialNumber;
            this.item = new Item(itemName, itemPrice);
            this.itemQuantity = itemQuantity;
            this.boxPrice = itemQuantity * item.itemPrice;
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Box> boxes = new List<Box>();

                string[] userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                while (userInput[0].ToLower() != "end")
                {
                    Box box = new Box(int.Parse(userInput[0]), userInput[1], int.Parse(userInput[2]), double.Parse(userInput[3]));
                    boxes.Add(box);

                    userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                }

                foreach (var box in boxes.OrderByDescending(x => x.boxPrice))
                {
                    Console.WriteLine(box.serialNumber);
                    Console.WriteLine($"-- {box.item.name} - ${box.item.itemPrice:F2}: {box.itemQuantity}");
                    Console.WriteLine($"-- ${box.boxPrice:F2}");
                }
            }
        }
    }
}
