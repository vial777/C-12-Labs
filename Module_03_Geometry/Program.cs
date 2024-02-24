﻿namespace Module_03_Geometry
{
    internal class Program
    {
        enum Figures { Romb, Rect, RightTriangle, Circle }
        struct Fdata
        {
            public int x0, y0;
            public double a, b;
            public int color;
            public Figures type;
        }
        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            Console.WriteLine(area(fd));
            Console.WriteLine("Ok");
        }
        static double area(Fdata fd) 
        {
            double res = 0;
            switch (fd.type)
            {
                case Figures.Circle: res = Math.PI * fd.a * fd.a / 4; break;
                case Figures.Rect: res = 1.0 * fd.a * fd.b; break;
                case Figures.Romb: res = .5 * fd.a * fd.b; break;
                case Figures.RightTriangle: res = .5 * fd.a * fd.b; break;
                default: break;
            }
            return res;
        }
    }
}
