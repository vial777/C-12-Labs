using System.Xml.Serialization;

namespace Module_10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Сериализация
      Book[] books = Books.TestBooks;
      using (StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "..", "books.txt")))
      {
        XmlSerializer xml = new XmlSerializer(books.GetType());
        xml.Serialize(sw, books);
      }

      books = null;
      //Десериализация
      using (StreamReader reader = new StreamReader(Path.Combine("..", "..", "..", "books.txt")))
      {
        XmlSerializer xml = new XmlSerializer(typeof(Book[]));
        books = (Book[])xml.Deserialize(reader);

        foreach (var b in books)
          Console.WriteLine(b);

        
      }

      //Book2
      Books2 books2 = new Books2();
      // Сериализация Books2
      using (StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "..", "books2.txt")))
      {
        XmlSerializer xml = new XmlSerializer(books2.GetType());
        xml.Serialize(sw, books2);
      }

      Console.WriteLine("___________________________________________________________");
      books2 = null;

      using (StreamReader reader = new StreamReader(Path.Combine("..", "..", "..", "books2.txt")))
      {
        XmlSerializer xml = new XmlSerializer(typeof(Books2));
        books2 = (Books2)xml.Deserialize(reader);

        foreach (var b in books2)
          Console.WriteLine(b);

       
      }

    }
  }
}
