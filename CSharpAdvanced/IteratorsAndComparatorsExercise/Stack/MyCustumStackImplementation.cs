using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class MyCustumStackImplementation<T> : IEnumerable<T>
    {
        private List<T> _stack;

        public MyCustumStackImplementation()
        {
            _stack = new List<T>();
        }

        public void Push(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                _stack.Add(item);
            }
        }

        public void Pop()
        {
            if (_stack.Count > 0)
            {                
                _stack.RemoveAt(_stack.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            _stack.Reverse();

            foreach (var item in _stack)
            {
                yield return item;
            }

            _stack.Reverse();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
