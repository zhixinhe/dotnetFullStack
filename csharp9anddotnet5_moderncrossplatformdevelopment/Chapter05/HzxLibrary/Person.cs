using System;
using System.Collections.Generic;

namespace Hzx.Shared
{
    public class Person : Object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        public virtual void Introduce()
        {
            Console.WriteLine("I'm a person.");
        }
    }

    public class Man: Person
    {
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("and I'm a man");
        }
    }
}


