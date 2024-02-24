using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    public class Circle : Shape
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

        public Circle(int x, int y, int r, string color = DEFAULT_COLOR)
            : base(color)
        {
            X = x; Y = y; radius = r;
        }

        public override string ToString()
        {
            return $"Circle ({X}, {Y}) {this.Radius} {Color}";
        }
        public override void Draw()
        {
            Console.WriteLine(this); 
        }
        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius / factor);
        }
    }
}
