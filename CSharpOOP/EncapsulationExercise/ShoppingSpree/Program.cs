using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            List<Product> products = new List<Product>();

            string[] userInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var item in userInput)
                {
                    var temp = item.Split('=');

                    Person currentPerson = new Person(temp[0], double.Parse(temp[1]));

                    people.Add(currentPerson);
                }

                userInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in userInput)
                {
                    var temp = item.Split('=');

                    Product currentProduct = new Product(temp[0], double.Parse(temp[1]));

                    products.Add(currentProduct);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ParamName);
            }

            List<string> command = new List<string>();

            try
            {
                while (true)
                {
                    command = Console.ReadLine().Split(" ").ToList();

                    if (command[0].ToUpper() == "END")
                    {
                        break;
                    }

                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i].Name == command[0])
                        {
                            for (int j = 0; j < products.Count; j++)
                            {
                                if (products[j].Name == command[1])
                                {
                                    people[i].BuyProduct(products[j]);

                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ParamName);
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");

                int index = person.ShoppingBag.Count;

                if (index == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    foreach (var item in person.ShoppingBag)
                    {
                        if (index != 1)
                        {
                            Console.Write($"{item.Name}, ");
                        }
                        else
                        {
                            Console.WriteLine(item.Name);
                        }

                        index--;
                    }
                }                
            }
        }
    }
}
