using System.Collections.Generic;

namespace Module_06
{
    internal class Program
    {
        static void DrawScene(IEnumerable<Shape> scene)
        {
            foreach (Shape s in scene)
                s.Draw();
        }

        static void Main(string[] args)
        {
            Circle c1 = new Circle(10, 20, 100, "green");
            Point po1 = new Point(10, 20, "pink");
            Line l1 = new Line(1, 1, 10, 10, "red");
            Shape[] scene = { c1, po1, l1 };
            DrawScene(scene);
        }
    }
}
