using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Battery { get => battery; set => battery = value; }

        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries"
                    + Environment.NewLine + this.Start()
                    + Environment.NewLine + this.Stop();
        }
    }
}
