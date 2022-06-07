using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string AskForFood()
        {
            return $"Hoot Hoot";
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.25;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
