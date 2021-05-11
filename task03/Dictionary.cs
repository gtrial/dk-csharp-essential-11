using System.Collections.Generic;
using System.Linq;

namespace task03
{
    public class Dictionary<TKey, TValue>
    {
        private IEnumerable<TKey> _keys;
        private IEnumerable<TValue> _values;

        public Dictionary(IEnumerable<TKey> keys, IEnumerable<TValue> values)
        {
            _keys = keys;
            _values = values;
        }

        public void Add(TKey key, TValue value)
        {
            _keys = _keys.Append(key);
            _values = _values.Append(value);
        }

        public TValue this[int i] => _values.ElementAt(i);

        public int Count => _keys.Count();
    }
}