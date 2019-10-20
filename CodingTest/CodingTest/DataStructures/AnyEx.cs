using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    public static class AnyEx
    {

        public static void AnyMethod()
        {
            List<int> numbers = new List<int> { 1, 2 };
            bool hasElements = numbers.Any();

            Console.WriteLine("The list {0} empty.", hasElements ? "is not" : "is");

            // This code produces the following output:
            // The list is not empty.
        }
        public static void AnyMethod2()
        {
            Pet[] pets = { 
                new Pet { Name="Barley", Age=8, Vaccinated=true },
                new Pet { Name="Boots", Age=4, Vaccinated=false },
                new Pet { Name="Whiskers", Age=1, Vaccinated=false } };

            // Determine whether any pets over age 1 are also unvaccinated.
            bool unvaccinated = pets.Any(p => p.Age > 1 && p.Vaccinated == false);

            Console.WriteLine("There {0} unvaccinated animals over age one.", unvaccinated ? "are" : "are not any");
        }
        public static void AnyMethodPet()
        {
            List<Person> people = new List<Person>
            { 
                new Person { LastName = "Haas", Pets = new Pet[] { new Pet { Name="Barley", Age=10 }, new Pet { Name="Boots", Age=14 }, new Pet { Name="Whiskers", Age=6 }}},
                new Person { LastName = "Fakhouri", Pets = new Pet[] { new Pet { Name = "Snowball", Age = 1}}},
                new Person { LastName = "Antebi", Pets = new Pet[] { }},
                new Person { LastName = "Philips", Pets = new Pet[] { new Pet { Name = "Sweetie", Age = 2}, new Pet { Name = "Rover", Age = 13}} }
            };

            // Determine which people have a non-empty Pet array.
            IEnumerable<string> names = from person in people
                                        where person.Pets.Any()
                                        select person.LastName;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            /* This code produces the following output:
                Haas
                Fakhouri
                Philips
            */
        }
    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Vaccinated { get; set; }
    }
    class Person
    {
        public string LastName { get; set; }
        public Pet[] Pets { get; set; }
    }

}
