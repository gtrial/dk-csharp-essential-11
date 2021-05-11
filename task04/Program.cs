using System;

namespace task04
{
    internal static class Program
    {
        private static void Main()
        {
            var arrayList = new ArrayList();
            Console.WriteLine(arrayList.Length);
            if (arrayList.Length > 0)
            {
                Console.WriteLine(arrayList);
            }

            arrayList.Add("one");
            Console.WriteLine(arrayList.Length);
        }
    }
}