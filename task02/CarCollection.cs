using System.Linq;

namespace task02
{
    public class CarCollection<T>
    {
        private T[] Cars { get; set; }

        public CarCollection(T[] items)
        {
            Cars = items;
        }

        public void Add(T item)
        {
            var enumerable = Cars.Append(item);
        }

        public T this[int i] => Cars[i];

        public int Length()
        {
            return Cars.Length;
        }

        public void RemoveAll()
        {
            Cars = new T[]{};
        }
    }
}