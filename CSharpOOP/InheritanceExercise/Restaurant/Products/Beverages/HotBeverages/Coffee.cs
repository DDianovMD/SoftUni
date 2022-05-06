using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {

        public Coffee(string name, double caffeine)
            : base(name, 3.50m, 50d) 
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
        public virtual decimal CoffeePrice => this.Price;
        public virtual double CoffeeMilliliters => this.Milliliters;
    }
}
