namespace _04.Students
{
    internal class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split()
                                        .ToArray();

                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                students.Add(student);
            }

            students = students.OrderByDescending(student => student.Grade)
                               .ToList();

            students.ForEach(student => Console.WriteLine(student));
        }
    }
}
