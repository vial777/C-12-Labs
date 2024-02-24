namespace Module_13
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Client c1 = new();
      Client c2 = new();

     // FindFiles ff1 = new(".\\obj", "json");
      FindFiles ff2 = new(".", "json");

     // ff1.Done += c1.fileGet;
      ff2.Done += c2.fileGet;

      ff2.Find();
      Console.WriteLine("end");
    }
  }
}
