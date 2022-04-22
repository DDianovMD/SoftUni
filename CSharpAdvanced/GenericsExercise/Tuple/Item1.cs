using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class Item1<T>
    {
        public T ClassItem { get; set; }

        public Item1(T item)
        {
            this.ClassItem = item;
        }
    }
}
