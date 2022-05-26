using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        public Pizza(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => name; 
            
            set
            {
                if (value != string.Empty && value != "" && value.Length >= 1 && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }
        public Dough dough { get; set; }
        public List<Topping> toppings { get; private set; } = new List<Topping>();
        public int ToppingsCount { get => toppings.Count; }

        public void AddTopping(Topping givenTopping)
        {
            if (toppings.Count <= 10)
            {
                toppings.Add(givenTopping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public double TotalCalories()
        {
            double calories = 0;

            foreach (var item in toppings)
            {
                calories += item.TotalCalories();
            }

            return calories + this.dough.TotalCalories();
        }
    }
}
