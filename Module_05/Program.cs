namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(1, 1, 10);
            c1.MoveBy(100,200);
            c1.Scale(1.5);
            c1.Draw();

            Date now = new Date(2024, 2,13);
            Console.WriteLine(now.Validate());
            now.Print();

            Date now1 = new Date(2023, 9, 31);
            Console.WriteLine(now1.Validate());
            now1.Print();
        }
    }
}
