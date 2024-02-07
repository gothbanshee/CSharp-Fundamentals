namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Shoot":
                        if (IndexOutOfArray(targets, command))
                        {
                            continue;
                        }

                        targets[int.Parse(command[1])] -= int.Parse(command[2]);

                        if (targets[int.Parse(command[1])] <= 0)
                        {
                            targets.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Add":
                        if (IndexOutOfArray(targets, command))
                        {
                            Console.WriteLine("Invalid placement!");
                            continue;
                        }

                        targets.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Strike":
                        if (int.Parse(command[1]) - int.Parse(command[2]) < 0 || int.Parse(command[1]) + int.Parse(command[2]) >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }

                        targets.RemoveRange(int.Parse(command[1]) - int.Parse(command[2]), int.Parse(command[2]) * 2 + 1);
                            break;
                }
            }

            Console.WriteLine(String.Join("|", targets));
        }

        static bool IndexOutOfArray(List<int> targets, string[] command)
        {
            if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= targets.Count)
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