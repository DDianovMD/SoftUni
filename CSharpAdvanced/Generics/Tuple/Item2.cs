using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class Item2<T>
    {
        public T ClassItem { get; set; }

        public Item2(T item)
        {
            this.ClassItem = item;
        }
    }
}
