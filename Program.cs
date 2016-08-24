using System;
using System.Collections.Generic;
using System.Linq;

namespace Xamarin.Course.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<Pet>()
            {
                new Pet("Rudolph the Goldfish", new AnimalKind("Goldfish", AnimalType.Fish, eyes: 2, legs: 0)),
                new Pet("Hugo", new AnimalKind("Dog", AnimalType.Bird)),
                new Pet("Kaptajn Kaper", new AnimalKind("Parrot", AnimalType.Bird)),
                new Pet("Mr. Hammer Jr.", new AnimalKind("Millipede", AnimalType.Fish, eyes: 2, legs: 1000)),
                new Pet("Ms. Silk", new AnimalKind("Spider", AnimalType.Bird, eyes: 6, legs: 8))
            };

            var people = new List<Person>()
            {
                new Person("Anders And", 1934),
                new Person("Mr. Hammer", 1975, pets[3]),
                new Person("Sørøver John", 1969, pets[2]),
                new Person("Bent Tonse", 1973, pets[0]),
                new Person("Fyrst Walter", 1965),
                new Person("Gentleman Finn", 1972, pets[4]),
                new Person("Newton Dynamose", 1657)
            };

            var query = ...;

            foreach (var item in query)
            {
                Console.WriteLine(...);
            }

            Console.ReadKey();
        }
    }
}
