namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] result = Console.ReadLine().Split();
                long left = long.Parse(result[0]);
                long right = long.Parse(result[1]);

                long sum = GetSumOfDigits(Math.Abs(Math.Max(left, right)));
                Console.WriteLine(sum);
            }
        }

        private static long GetSumOfDigits(long number)
        {
            long sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}