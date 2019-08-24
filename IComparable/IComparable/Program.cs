using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person {Age=27,Name="Mickey",Gender=1},
                new Person {Age=24,Name="David",Gender=1},
                new Person {Age=23,Name="Jeff",Gender=2},
            };
            Console.WriteLine("============IComparable============");
            foreach (var person in persons.OrderBy(r => r))
            {
                Console.WriteLine(string.Format("Age:{0},Name:{1},Gender:{2}",
                    person.Age, person.Name, person.Gender));
            }

            Array.Sort(persons, new OrderByAgeDesc());
            Console.WriteLine("============IComparer============");
            foreach (var person in persons)
            {
                Console.WriteLine(string.Format("Age:{0},Name:{1},Gender:{2}",
                    person.Age, person.Name, person.Gender));
            }

            Console.Read();
        }
    }

    public class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }

    public class OrderByAgeDesc : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return y.Age.CompareTo(x.Age);
        }
    }
}
