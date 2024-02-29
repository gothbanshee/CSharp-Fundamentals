using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using static _05.TeamworkProjects.Program;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        internal class Team
        {
            public Team(string name, string creator)
            {
                Name = name;
                Creator = creator;
                Members = new List<string>();
            }

            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public override string ToString()
            {
                return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMembersString()}";
            }

            private string GetMembersString()
            {
                Members = Members.OrderBy(name => name)
                                 .ToList();

                string result = "";
                for (int i = 0; i < Members.Count - 1; i++)
                {
                    result += $"-- {Members[i]}\n";
                }
                result += $"-- {Members[Members.Count - 1]}";

                return result;
            }
        }

        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 1; i <= teamsCount; i++)
            {
                string[] command = Console.ReadLine().Split("-");
                Team team = new Team(command[1], command[0]);

                if (!teams.Exists(team => team.Name == command[1]) && !teams.Exists(team => team.Creator == command[0]))
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
                else if (teams.Exists(team => team.Name == command[1]))
                {
                    Console.WriteLine($"Team {command[1]} was already created!");
                }
                else if (teams.Exists(team => team.Creator == command[0]))
                {
                    Console.WriteLine($"{command[0]} cannot create another team!");
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] command = input.Split("->");

                string name = command[0];
                string teamToJoin = command[1];

                if (!teams.Exists(team => team.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Exists(team => team.Members.Contains(name) || team.Creator == name))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamToJoin}!");
                }
                else
                {
                    teams.Find(team => team.Name == teamToJoin).Members.Add(name);
                }
            }

            teams = teams.OrderByDescending(team => team.Members.Count)
                         .ThenBy(team => team.Name)
                         .ToList();

            List<Team> toDisband = new List<Team>();

            foreach (Team team in teams)
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team);
                }
                else
                {
                    toDisband.Add(team);
                }
            }

            toDisband = toDisband.OrderBy(team => team.Name).ToList();
            Console.WriteLine("Teams to disband:");
            toDisband.ForEach(team => Console.WriteLine(team.Name));
        }
    }
}