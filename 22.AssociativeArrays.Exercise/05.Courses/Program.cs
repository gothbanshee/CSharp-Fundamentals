
namespace _05.Courses
{
    class Course
    {
        public Course(string name, List<string> students)
        {
            Name = name;
            Students = students;
        }

        public string Name { get; }
        public List<string> Students { get; }

        public override string ToString()
        {
            return $"{Name}: {Students.Count}\n{GetStudents()}";
        }

        private string GetStudents()
        {
            string result = "";
            foreach (var student in Students)
            {
                result += $"-- {student}\n";
            }
            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ")
                                        .ToArray();

                string courseName = command[0];
                string studentName = command[1];
                Course course = new Course(courseName, new List<string>());

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, course);
                }

                courses[courseName].Students.Add(studentName);
            }

            foreach (var keyValuePair in courses)
            {
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}