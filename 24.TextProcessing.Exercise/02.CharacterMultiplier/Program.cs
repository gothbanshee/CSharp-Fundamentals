namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split()
                                    .ToArray();

            long sum = 0;
            for (int i = 0; i < Math.Min(input[0].Length, input[1].Length); i++)
            {
                sum += input[0][i] * input[1][i];
            }

            if (input[0].Length == input[1].Length)
            {
                Console.WriteLine(sum);
                return;
            }
            else if (input[0].Length > input[1].Length)
            {
                for (int i = Math.Min(input[0].Length, input[1].Length); i < input[0].Length; i++)
                {
                    sum += input[0][i];
                }
            }
            else
            {
                for (int i = Math.Min(input[0].Length, input[1].Length); i < input[1].Length; i++)
                {
                    sum += input[1][i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
