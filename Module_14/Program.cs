using System.Linq;

namespace Module_14
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book[] books = Books.TestBooks;
      var avrAll = (from b in books select b.Price).Average();

     // var avrAll = books.Select(x => x.Price).Average();
      Console.WriteLine("{0:F}", avrAll);
      var avrTech = (from b in books
                     where b.Genre == "tech"
                     select b.Price).Average();

      //var avrTech = books.Where(x => x.Genre == "tech").Select(x => x.Price).Average();
      Console.WriteLine("{0:F}", avrTech);

      var avrBy = books.GroupBy(x => x.Genre)
                .Select(x => new { genre = x.Key, avr = x.Select(x => x.Price).Average() });
      foreach (var item in avrBy) Console.WriteLine(item);

      Console.WriteLine("Ok");
    }
  }
}
