using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson20
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name,12}   ID: {Id,4}   Age: {Age,4}   Height: {Height,5}";
        }
        public int CompareTo(Person person)
        {
            return this.Id - person.Id;
        }
    }
}
