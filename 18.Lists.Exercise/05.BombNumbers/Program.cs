namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            int[] bomb = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            while (numbers.Contains(bomb[0]))
            {
                int start = Math.Max(numbers.FindIndex(x => x == bomb[0]) - bomb[1], 0);
                int count = Math.Min(bomb[1] * 2 + 1, numbers.Count - start);
                numbers.RemoveRange(start, count);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}