using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
    
        private int radius;
        public int Radius 
        { 
            get => radius;
            set 
            {
                if (value > 0) radius = value;
                else throw new ArgumentException("radius <= 0");
            } 
        }
        public Circle(int x, int y, int r) 
        { 
            X =x; Y = y; radius = r;
        }

        public double Area() => Math.PI * Math.Pow(Radius, 2);

        public void MoveBy(int dx, int dy)
        { 
            X += dx; Y += dy; 
        }

        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius / factor);
        }

        public void Draw()
        {
            Console.WriteLine($"Circle ({X} {Y}) {Radius}");
        }

    }
}
