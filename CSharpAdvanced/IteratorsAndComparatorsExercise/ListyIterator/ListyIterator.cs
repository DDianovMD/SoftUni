using System;
using System.Collections.Generic;

namespace _ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> _collection;
        private int _index = 0;
        public ListyIterator(IEnumerable<T> collection)
        {
            _collection = new List<T>(collection);
        }

        public bool Move()
        {
            if (HasNext())
            {
                _index++;
                return true;
            }

            return false;
        }
        public bool HasNext()
        {
            if (_index + 1 < _collection.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (_collection.Count > 0)
            {
                Console.WriteLine(_collection[_index]);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
