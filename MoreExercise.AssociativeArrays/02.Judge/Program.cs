namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] command = input.Split(" -> ");
                string username = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);

                if (!users.ContainsKey(username))
                {
                    users.Add(username, 0);
                }

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                }

                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, points);
                    users[username] += points;
                }
                else if (contests[contest][username] < points)
                {
                    users[username] += points - contests[contest][username];
                    contests[contest][username] = points;
                }

                contests[contest] = contests[contest].OrderByDescending(u => u.Value)
                    .ThenBy(u => u.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                users = users.OrderByDescending(u => u.Value)
                             .ThenBy(u => u.Key)
                             .ToDictionary(x => x.Key, x => x.Value);
            }

            foreach (var keyValuePair in contests)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value.Count} participants");
                int i = 1;
                foreach (var participants in keyValuePair.Value)
                {
                    Console.WriteLine($"{i}. {participants.Key} <::> {participants.Value}");
                    i++;
                }
            }

            Console.WriteLine("Individual standings:");

            int j = 1;
            foreach (var user in users)
            {
                Console.WriteLine($"{j}. {user.Key} -> {user.Value}");
                j++;
            }
        }
    }
}