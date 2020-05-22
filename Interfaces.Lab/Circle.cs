using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Lab
{
    class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;

        }
        public void Draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; --y) 
            {
                for (double x = -this.Radius; x < rOut; x += 0.5) 
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        private double Radius {
            get
            {
                return this.radius;
            }
            set 
            {
                this.radius = value;
            }
        }
    }
}
