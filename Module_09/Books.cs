using System;
using System.Collections;

namespace Module_09
{
    class Books : IEnumerable
  {
        Book[] books;
        public Books() { books = Book.TestBooks(); }

    public IEnumerator GetEnumerator()
    {
      
      return books.GetEnumerator();
    }
    public IEnumerable GetByAuthor()
    {
      return new EnumAuthor(books);
    }
    public IEnumerable GetReverseEnum()
    {
      for (int i = books.Length - 1; i >= 0; i--)
        yield return books[i];
    }
    public IEnumerable GetByPrice()
    {
      Book[] data = (Book[])books.Clone();
      Array.Sort(data, Book.ByPrice());

      for (int i = 0; i < data.Length; ++i)
        yield return data[i];
    }
  }
}
