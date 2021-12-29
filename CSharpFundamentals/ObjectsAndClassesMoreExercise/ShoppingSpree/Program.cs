using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        public string name { get; set; }
        public decimal money { get; set; }
        public List<string> bagOfProducts { get; set; }

        public Person(string name, decimal money)
        {
            this.name = name;
            this.money = money;
            this.bagOfProducts = new List<string>();
        }
    }

    public class Product
    {
        public string name { get; set; }
        public decimal cost { get; set; }

        public Product(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleAndMoney = new List<string>();
            List<string> productsAndCost = new List<string>();

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < 2; i++)
            {
                List<string> userInput = Console.ReadLine()
                    .Split(";")
                    .ToList();

                if (i == 0)
                {                    
                    for (int j = 0; j < userInput.Count; j++)
                    {
                        peopleAndMoney = userInput[j].Split("=", StringSplitOptions.RemoveEmptyEntries)
                           .ToList();

                        Person currentPerson = new Person(peopleAndMoney[0], decimal.Parse(peopleAndMoney[1]));
                        people.Add(currentPerson);

                        peopleAndMoney.Clear();
                    }
                }
                else
                {
                    for (int j = 0; j < userInput.Count; j++)
                    {
                        productsAndCost = userInput[j].Split("=", StringSplitOptions.RemoveEmptyEntries)
                           .ToList();

                        Product currentProduct = new Product(productsAndCost[0], decimal.Parse(productsAndCost[1]));
                        products.Add(currentProduct);

                        productsAndCost.Clear();
                    }
                }                
            }

            bool keepGoing = true;

            while (keepGoing)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0].ToLower() == "end")
                {
                    keepGoing = false;
                    break;
                }

                foreach (var person in people.Where(x => x.name == command[0]))
                {
                    foreach (var product in products.Where(x => x.name == command[1]))
                    {
                        if (person.money - product.cost >= 0)
                        {
                            Console.WriteLine($"{person.name} bought {product.name}");
                            person.money -= product.cost;
                            person.bagOfProducts.Add(product.name);
                        }
                        else
                        {
                            Console.WriteLine($"{person.name} can't afford {product.name}");
                        }
                    }
                }
            }

            foreach (var person in people)
            {
                Console.Write($"{person.name} - ");
                if (person.bagOfProducts.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", person.bagOfProducts));
                }
                else
                {
                    Console.WriteLine("Nothing bought");
                }
            }
        }
    }
}
