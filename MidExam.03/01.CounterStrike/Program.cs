namespace _01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battles = 0;
            string neededStr = Console.ReadLine();


            while (neededStr != "End of battle")
            {
                int needed = int.Parse(neededStr);
                if (energy < needed)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battles} won battles and {energy} energy");
                    break;
                }

                battles++;
                energy -= needed;

                if (battles % 3 == 0)
                {
                    energy += battles;
                }

                neededStr = Console.ReadLine();
            }
            if (neededStr == "End of battle")
            {
                Console.WriteLine($"Won battles: {battles}. Energy left: {energy}");
            }
        }
    }
}
