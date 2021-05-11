using System;

namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            var dictionary = new Dictionary<int, string>(new[] {1, 2}, new[] {"One", "Two"});
            dictionary.Add(3, "Three");
            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary.Count);
        }
    }
}