#nullable enable
using System;
using System.Linq;

namespace task04
{
    public class ArrayList
    {
        private object?[] _items;

        public ArrayList()
        {
            _items = Array.Empty<object>();
        }

        public int Length => _items.Length;

        public object? this[int index] => _items[index];

        public void Add(object? item)
        {
            _items = new object?[] {_items.Append(item)};
        }
    }
}