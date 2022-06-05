using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get => radius; set => radius = value; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
