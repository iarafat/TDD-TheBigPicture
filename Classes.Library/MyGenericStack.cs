using System;
using System.Collections.Generic;

namespace Classes.Library
{
    public class MyGenericStack<T>
    {
      private List<T> _item = new List<T>();

      public MyGenericStack<T> Push(T item)
      {
        _item.Add(item);
        return this;
      }

      public T Pop()
      {
        if(_item.Count == 0)
        {
            return default(T);
        }
        else {
            var item = _item[_item.Count - 1];
            _item.RemoveAt(_item.Count - 1);
            return item;
        }
      }
    }
}