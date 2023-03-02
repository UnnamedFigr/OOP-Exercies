using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opinion_Poll
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public static List<Person> GetPeople(List<Person> people)
        {
            return people.Where(p => p.Age >= 30)
                .OrderBy(p => p.Name).ToList();

        }


    }
}
