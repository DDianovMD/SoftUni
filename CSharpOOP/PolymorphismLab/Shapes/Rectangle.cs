using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Height + 2 * Width;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(new string('*', Width));
            for (int i = 0; i < Height - 2; i++)
            {
                sb.AppendLine('*' + new string(' ', Width - 2) + '*');
            }
            sb.AppendLine(new string('*', Width));

            return sb.ToString();
        }
    }
}
