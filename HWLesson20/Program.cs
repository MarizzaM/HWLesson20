using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson20
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(01, 65, 170.0f, "Wizard");
            Person p2 = new Person(02, 155, 181.0f, "Demon ");
            Person p3 = new Person(03, 43, 160.0f, "Witch Doctor");
            Person p4 = new Person(04, 33, 250.0f, "Barbarian");
            Person p5 = new Person(05, 120, 140.0f, "Monk");

            Person[] persons = { p1, p2, p3, p4, p5 };

            PrintPersonArray(persons);

            Console.WriteLine("\nCompare by id:");
            Array.Sort(persons);
            PrintPersonArray(persons);

            Console.WriteLine("\nCompare by Name:");
            Array.Sort(persons, new PersonCompareByName());
            PrintPersonArray(persons);

            Console.WriteLine("\nCompare by Age:");
            Array.Sort(persons, new PersonCompareByAge());
            PrintPersonArray(persons);

            Console.WriteLine("\nCompare by Height:");
            Array.Sort(persons, new PersonCompareByHeight());
            PrintPersonArray(persons);
        }

        static void PrintPersonArray(Person[] persons) {
            foreach (Person p in persons) {
                Console.WriteLine(p);
            }
        }
    }
}
