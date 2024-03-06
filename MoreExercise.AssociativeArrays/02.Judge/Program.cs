
using System.Collections.Generic;

namespace _02.Judge
{
    class User
    {
        public User(string username, int points)
        {
            Username = username;
            Points = points;
        }

        public string Username { get; set; }
        public int TotalPoints { get; set; }
        public int Points { get; set; }

        public override string ToString()
        {
            return $"{Username} -> {TotalPoints}";
        }
    }

    class Contest
    {
        public Contest(string contestName, List<User> users)
        {
            ContestName = contestName;
            Users = users;
        }

        public string ContestName { get; set; }
        public List<User> Users { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            Dictionary<string, List<User>> contests = new Dictionary<string, List<User>>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] command = input.Split(" -> ");
                string username = command[0];
                string contestName = command[1];
                int points = int.Parse(command[2]);

                User user = new(username, points);
                if (!users.Exists(s => s.Username == username))
                {
                    users.Add(user);
                }


                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, new List<User>());
                }

                if (!contests[contestName].Exists(s => s.Username == username))
                {
                    contests[contestName].Add(user);
                }

                if (contests[contestName].First(s => s.Username == username).Points < points)
                {
                    contests[contestName].First(s => s.Username == username).Points = points;
                }
                contests[contestName] = contests[contestName].OrderByDescending(s => s.Points)
                                                             .ThenBy(s => s.Username)
                                                             .ToList();

                if (contests[contestName].Exists(s => s.Username == username) && users.First(s => s.Username == username).Points < points)
                {
                    users.First(s => s.Username == username).TotalPoints += Math.Abs((users.First(s => s.Username == username).Points) - points);
                    users.First(s => s.Username == username).Points = points;
                                    }
                else if (users.Exists(s => s.Username == username))
                {
                    users.First(s => s.Username == username).TotalPoints += points;
                }
            }

            foreach (var keyValuePair in contests)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value.Count} participants");

                int i = 1;

                foreach (var userKVP in keyValuePair.Value)
                {
                    Console.WriteLine($"{i}. {userKVP.Username} <::> {userKVP.Points}");
                    i++;
                }
            }

            Console.WriteLine("Individual standings:");

            users = users.OrderByDescending(s => s.TotalPoints)
                         .ThenBy(s => s.Username)
                         .ToList();

            for (int i = 1; i <= users.Count; i++)
            {
                Console.WriteLine($"{i}. {users[i - 1]}");
            }
        }
    }
}