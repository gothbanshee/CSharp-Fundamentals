namespace _05.Students2._0
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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

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

                if (students.Exists(s => s.FirstName == command[0] && s.LastName == command[1]))
                {
                    students.First(s => s.FirstName == command[0] && s.LastName == command[1]).Age = int.Parse(command[2]);
                    students.First(s => s.FirstName == command[0] && s.LastName == command[1]).Hometown = command[3];
                }
                else
                {
                    students.Add(new Student(command[0], command[1], int.Parse(command[2]), command[3]));
                }
            }

            string town = Console.ReadLine();

            Console.WriteLine(String.Join("\n", students.Where(s => s.Hometown == town)));
        }
    }
}
