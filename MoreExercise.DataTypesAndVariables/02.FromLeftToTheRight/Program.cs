namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string whole = Console.ReadLine();

                string[] result = whole.Split(' ');
                long left = long.Parse(result[0]);
                long right = long.Parse(result[1]);

                if (left >= right)
                {
                    long sum = 0;

                    for (int j = 0; j < result[0].Length; j++)
                    {
                        sum += left % 10;
                        left /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
                else
                {
                    long sum = 0;

                    for (int j = 0; j < result[1].Length; j++)
                    {
                        sum += right % 10;
                        right /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
            }
        }
    }
}