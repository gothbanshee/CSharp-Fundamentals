namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            while (start <= end)
            {
                sum += start;
                Console.Write($"{start} ");
                start++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
