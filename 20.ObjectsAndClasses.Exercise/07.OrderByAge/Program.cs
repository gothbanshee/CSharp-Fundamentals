namespace _07.OrderByAge
{
    internal class Program
    {
        internal class Person
        {
            public Person(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                Person newPerson = new Person(command[0], command[1], int.Parse(command[2]));

                var foundPerson = people.FirstOrDefault(person => person.ID == newPerson.ID);
                if (foundPerson != null)
                {
                    foundPerson.Name = newPerson.Name;
                    foundPerson.Age = newPerson.Age;
                }
                else
                {
                    people.Add(newPerson);
                }

            }

            List<Person> orderedPeople = people.OrderBy(person => person.Age).ToList();

            foreach (Person person in orderedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
