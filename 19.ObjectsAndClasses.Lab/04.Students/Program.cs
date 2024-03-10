namespace _04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string Hometown { get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split()
                                        .ToArray();

                students.Add(new Student(command[0], command[1], int.Parse(command[2]), command[3]));
            }
            
            string town = Console.ReadLine();

            Console.WriteLine(String.Join("\n", students.Where(s => s.Hometown == town)));
        }
    }
}
