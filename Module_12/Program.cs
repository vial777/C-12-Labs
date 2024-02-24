namespace Module_12
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Circle c1 = new Circle(10,10,50);
      Circle c2 = new Circle(10, 10, 50);
      Circle c3 = new Circle(20, 20, 50);
      Console.WriteLine(c1 == c2);
      Console.WriteLine(c1 == c3);
      Console.WriteLine(c2 != c3);
    }
  }
}
