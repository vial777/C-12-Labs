namespace Module_02
{
    enum Figures { Romb, Circle, Rect }
    struct FData
    {
        public int x0, y0;      // координаты центра тяжести
        public int color;   // цвет фигуры
        public Figures type;	// тип фигуры

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FData data = new FData { x0 = 1, y0 = 1, color = 0x2727FF, type = Figures.Romb };
            string result = string.Format("{0:X0}", data.color);
            Console.WriteLine($"({data.x0}, {data.y0}) 0x{result} {data.type}");

            //int? kq = null;
            //kq = 5;
            //if (kq.HasValue)
            //    Console.WriteLine(kq.Value);
            //else 
            //    Console.WriteLine("No value");


            //int? a = null;
            //Console.WriteLine((a ?? 3));
        }
    }
}
