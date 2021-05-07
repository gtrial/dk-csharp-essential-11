using System;

namespace task02
{
    internal static class Program
    {
        private class Car
        {
            private string Name { get; }
            private DateTime Year { get; }

            public Car(string name, DateTime year)
            {
                Name = name;
                Year = year;
            }
        }

        private static void Main()
        {
            var car1 = new Car("Car name One", DateTime.Now);
            var car2 = new Car("Car name Two", DateTime.Now);
            var carCollection = new CarCollection<Car>(new[] {car1, car2});
            carCollection.Add(new Car("Car name Three", DateTime.Now));
            var carN = carCollection[0];
            Console.WriteLine(carN.ToString());
            Console.WriteLine(carCollection.Length());
            carCollection.RemoveAll();
            Console.WriteLine(carCollection.Length());
        }
    }
}