using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return $"Squeak";
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.1;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
