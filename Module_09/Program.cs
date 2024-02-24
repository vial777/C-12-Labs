namespace Module_09
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Books books = new Books();
      foreach (Book b in books) 
        Console.WriteLine(b);
      Console.WriteLine("_______________________ByAuthor____________________________");
      foreach (Book book in books.GetByAuthor()) Console.WriteLine(book);
      Console.WriteLine("_______________________ReverseEnum_________________________");
      foreach (Book book in books.GetReverseEnum()) Console.WriteLine(book);
      Console.WriteLine("_______________________ByPrice_____________________________");
      foreach (Book book in books.GetByPrice()) Console.WriteLine(book);

    }
  }
}
