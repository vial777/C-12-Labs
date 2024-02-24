﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09
{
 public class EnumAuthor : IEnumerable, IEnumerator
  {
    int i = -1;
    Book[] data;

    internal EnumAuthor(Book[] books)
    {
      data = (Book[])books.Clone();
      Array.Sort(data, Book.ByAuthor());
    }

    public object Current =>  data[i];

    public IEnumerator GetEnumerator()
    {
      return this;
    }

    public bool MoveNext()
    {
      i++;
      if (i < data.Length) return true;
      else return false;
    }

    public void Reset()
    {
      i = -1;
    }
  }
}
