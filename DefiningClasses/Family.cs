using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Family
    {
        public List<Person> People { get; set; }

        public Family()
        {
            this.People = new List<Person>();
        }

        public void AddMember (Person member)
        {
            this.People.Add(member);
        }
        
        public Person GetOldestMember()
        {
            return this.People.OrderByDescending(n => n.Age).ToList()[0];
        }
    }
}
