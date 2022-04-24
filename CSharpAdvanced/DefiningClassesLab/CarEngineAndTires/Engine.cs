using System;

namespace CarManufacturer

{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get => horsePower; private set => horsePower = value; }
        public double CubicCapacity { get => cubicCapacity; private set => cubicCapacity = value; }

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
    }
}
