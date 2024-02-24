using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    public class Point :Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, string color = DEFAULT_COLOR)
            : base(color)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Draw()
        {           
            Console.WriteLine($"Point ({X}, {Y}) {Color}");
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
