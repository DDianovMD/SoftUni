using System;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
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
        public double Cost
        {
            get => cost; 
            
            private set
            {
                if (value >= 0)
                {
                    cost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Money cannot be negative");
                }
            }
        }
    }
}