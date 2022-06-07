using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "Meow";
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.3;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
