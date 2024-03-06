using System.Numerics;

namespace _03.MOBAChallenger
{
    class Player
    {
        public Player(string name, Dictionary<string, int> lanes)
        {
            Name = name;
            Lanes = lanes;
        }

        public string Name { get; set; }
        public Dictionary<string, int> Lanes { get; set; }

        public int TotalSkill => Lanes.Sum(kvp => kvp.Value);

        public void SortPlayer()
        {
            Lanes = Lanes.OrderByDescending(l => l.Value)
                         .ThenBy(l => l.Key)
                         .ToDictionary();
        }

        public override string ToString()
        {
            return $"{Name}: {TotalSkill} skill\n{GetLanes()}";
        }

        private string GetLanes()
        {
            string result = "";
            foreach (var keyValuePair in Lanes)
            {
                result += $"{keyValuePair.Key} <::> {keyValuePair.Value}\n";
            }
            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains(" vs "))
                {
                    string[] command = input.Split(" vs ");

                    string firstPlayer = command[0];
                    string secondPlayer = command[1];
                    int firstIndex = players.FindIndex(p => p.Name == firstPlayer);
                    int secondIndex = players.FindIndex(p => p.Name == secondPlayer);

                    if (players.Exists(p => p.Name == firstPlayer) && players.Exists(p => p.Name == secondPlayer))
                    {
                        List<string> firstPlayersLanes = players[firstIndex].Lanes.Keys
                                                                .ToList();

                        List<string> secondPlayersLanes = players[secondIndex].Lanes.Keys
                                                                .ToList();

                        if (firstPlayersLanes.Intersect(secondPlayersLanes).Count() != 0)
                        {

                        }
                    }
                }
                else
                {
                    string[] command = input.Split(" -> ");

                    string playerName = command[0];
                    string playerLane = command[1];
                    int laneSkill = int.Parse(command[2]);

                    Player player = new Player(playerName, new Dictionary<string, int>());

                    if (!players.Exists(p => p.Name == playerName))
                    {
                        players.Add(player);
                    }

                    if (!players.First(p => p.Name == playerName).Lanes.ContainsKey(playerLane))
                    {
                        players.First(p => p.Name == playerName).Lanes.Add(playerLane, laneSkill);
                    }
                    else if (players.First(p => p.Name == playerName).Lanes[playerLane] < laneSkill)
                    {
                        players.First(p => p.Name == playerName).Lanes[playerLane] = laneSkill;
                    }
                }
            }

            players = players.OrderByDescending(p => p.TotalSkill)
                             .ThenBy(p => p.Name)
                             .ToList();

            players.ForEach(p => p.SortPlayer());

            players.ForEach(Console.WriteLine);
        }
    }
}
