namespace _02.OldestFamilyMember
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    class Family
    {
        public void AddMember(string name, int age)
        {
            people.Add(new Person(name, age));
        }

        public Person GetOldestMember()
        {
            return people.OrderByDescending(p => p.Age)
                         .First();
        }

        List<Person> people = new List<Person>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < length; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split()
                                          .ToArray();

                family.AddMember(command[0], int.Parse(command[1]));
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}