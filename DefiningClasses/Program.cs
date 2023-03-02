using DefiningClasses;
using System.Security.Cryptography.X509Certificates;

class StartUp
{
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int membersCount);
        Family family = new Family();
            
        for (int i = 0; i < membersCount; i++)
        {
            string[] currentMember = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
            string name = currentMember[0];
            int age = int.Parse(currentMember[1]);

            Person person = new Person(name , age);
            family.AddMember(person);
        }
        Person oldestPerson = family.GetOldestMember();
        Console.WriteLine($"{oldestPerson.Name} | {oldestPerson.Age} years is the older person of all {membersCount} members");
       
    }
}