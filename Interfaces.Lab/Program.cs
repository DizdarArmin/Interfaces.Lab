using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle, radius : ");
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);
            circle.Draw();

            Console.WriteLine("Rectangle, width: ");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle, height: ");
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);
            rect.Draw();


            Console.ReadLine();


        }
    }
}
