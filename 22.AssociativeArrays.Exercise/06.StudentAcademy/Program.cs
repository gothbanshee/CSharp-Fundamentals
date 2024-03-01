namespace _06.StudentAcademy
{
    class Student
    {
        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
        }

        public string Name { get; }
        public List<double> Grades { get; }

        public override string ToString()
        {
            return $"{Name} -> {(Grades.DefaultIfEmpty().Average()):f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                Student student = new Student(name, new List<double>());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, student);
                }

                students[name].Grades.Add(grade);
            }
            
            var bestStudents = students.Where(s => (s.Value.Grades.Average()) >= 4.5).ToList();

            foreach (var keyValuePair in bestStudents)
            {
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}