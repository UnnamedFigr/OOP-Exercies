namespace Opinion_Poll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool succsess = int.TryParse(input, out int peopleCount);
            if (!succsess)
            {
                Console.WriteLine("Thex number is not in a correct format! Try a new one");
            }
            else
                Console.WriteLine($"The input \"{input}\" was succsessfully converted into integer {peopleCount} ");
        

            List<Person> people = new List<Person>();
        
            for(int i = 0; i < peopleCount; i++)
            {
                string[] member = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = member[0];
                int.TryParse(member[1], out int age);
                Person person = new Person(name, age);
                people.Add(person);
            }

            List<Person> results = Person.GetPeople(people);

            foreach(var person in results)
            {
                Console.WriteLine($"{person.Name} || {person.Age}");
            }

        }
    }
}