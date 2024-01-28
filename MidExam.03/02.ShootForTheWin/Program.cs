namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input;
            int totalShots = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int newTarget = int.Parse(input);
                if (newTarget < 0 || newTarget >= targets.Length || targets[newTarget] == -1)
                {
                    continue;
                }

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1 || i == newTarget)
                    {
                        continue;
                    }
                    else if (targets[i] <= targets[newTarget])
                    {
                        targets[i] += targets[newTarget];
                    }
                    else
                    {
                        targets[i] -= targets[newTarget];
                    }
                }

                targets[newTarget] = -1;
                totalShots++;
            }

            Console.WriteLine($"Shot targets: {totalShots} -> {String.Join(" ", targets)}");
        }
    }
}
