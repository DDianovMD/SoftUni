using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private readonly double length;
        private readonly double width;
        private readonly double height;

        public Box(double length, double width, double height)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else
            {
                this.length = length;
            }

            if (width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else
            {
                this.width = width;
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            else
            {
                this.height = height;
            }
        }

        public double Length => length;
        public double Width => width;
        public double Height => height;

        public double SurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double LateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            return 2 * length * height + 2 * width * height;
        }

        public double Volume()
        {
            //Volume = lwh
            return length * width * height;
        }
    }
}
