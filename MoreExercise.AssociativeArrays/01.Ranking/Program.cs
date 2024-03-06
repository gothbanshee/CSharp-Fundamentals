namespace _01.Ranking
{
    class Student
    {
        public Student(string username, Dictionary<string, int> usersContests)
        {
            Username = username;
            UsersContests = usersContests;
        }

        public string Username { get; set; }
        public int AllPoints => UsersContests.Values.Sum();
        public Dictionary<string, int> UsersContests { get; set; }

        public void AddContest(string contestName, int contestPoints)
        {
            if (!UsersContests.ContainsKey(contestName))
            {
                UsersContests.Add(contestName, contestPoints);
            }
        }

        public void UpdatePoints(string contestName, int contestPoints)
        {
            if (UsersContests[contestName] < contestPoints)
            {
                UsersContests[contestName] = contestPoints;
            }

            UsersContests = UsersContests.OrderByDescending(s => s.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public override string ToString()
        {
            return $"{Username}\n{GetAllContests()}";
        }

        public string GetAllContests()
        {
            string result = "";
            foreach (var keyValuePair in UsersContests)
            {
                result += $"#  {keyValuePair.Key} -> {keyValuePair.Value}\n";
            }
            return result.Trim();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> allStudents = new Dictionary<string, Student>();
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] command = input.Split(':');
                contests.Add(command[0], command[1]);
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] command = input.Split("=>");

                string contestName = command[0];
                string username = command[2];
                int contestPoints = int.Parse(command[3]);

                Student student = new Student(username, new Dictionary<string, int>());
                if (contests.ContainsKey(contestName) && contests.ContainsValue(command[1]))
                {
                    if (!allStudents.ContainsKey(username))
                    {
                        allStudents.Add(username, student);
                    }
                    allStudents[username].AddContest(contestName, contestPoints);
                    allStudents[username].UpdatePoints(contestName, contestPoints);
                }
            }

            allStudents = allStudents.OrderBy(s => s.Value.Username).ToDictionary(x => x.Key, x => x.Value);

            var bestStudent = allStudents.MaxBy(s => s.Value.AllPoints);

            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.AllPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var keyValuePair in allStudents)
            {
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}