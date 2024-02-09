
namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine()
                                        .Split("|")
                                        .ToList();


            string input;
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Loot":
                        chest.Reverse();
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (!chest.Contains(command[i]))
                            {
                                chest.Add(command[i]);
                            }
                        }
                        chest.Reverse();
                        break;
                    case "Drop":
                        if (!IndexOutOfArray(chest, command))
                        {
                            chest.Add(chest[int.Parse(command[1])]);
                            chest.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Steal":
                        if(int.Parse(command[1]) < 0)
                        {
                            continue;
                        }
                        List<string> stolenItems = new List<string>();
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            if (chest.Count == 0)
                            {
                                break;
                            }
                            stolenItems.Add(chest[chest.Count - 1]);
                            chest.RemoveAt(chest.Count - 1);
                        }
                        stolenItems.Reverse();
                        Console.WriteLine(String.Join(", ", stolenItems));
                        break;
                }
            }

            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < chest.Count; i++)
                {
                    sum += chest[i].Length;
                }
                Console.WriteLine($"Average treasure gain: {(sum / chest.Count):f2} pirate credits.");
            }
        }

        static bool IndexOutOfArray(List<string> chest, string[] command)
        {
            if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= chest.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}