using System;
namespace Classes.Library
{
    public class MyGenericStack<T>
    {
      private T _item;

      public void Push(T item)
      {
          _item = item;
      }

      public T Pop()
      {
          return _item;
      }
    }
}