namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int emptyWagons = lift.Length;

            for (int i = 0; i < lift.Length; i++)
            {
                while (lift[i] < 4)
                {
                    if (people <= 0)
                    {
                        break;
                    }
                    lift[i]++;
                    people--;
                }
                if (lift[i] == 4)
                {
                    emptyWagons--;
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            else if (emptyWagons != 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.WriteLine(String.Join(" ", lift));
        }
    }
}
