using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> shoppingBag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            shoppingBag = new List<Product>();
        }
        public string Name
        {
            get => name;

            private set
            {
                if (value != string.Empty && value != " " && value != "" && value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Name cannot be empty");
                }
            }
        }
        public double Money
        {
            get => money;

            private set
            {
                if (value >= 0)
                {
                    money = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Money cannot be negative");
                }
            }
        }
        public IReadOnlyCollection<Product> ShoppingBag
        {
            get => shoppingBag.AsReadOnly();
        }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                shoppingBag.Add(product);

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
