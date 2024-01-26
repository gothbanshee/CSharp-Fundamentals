namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int sumLeft = 0;
            int sumRight = 0;

            int i = 0;

            for (; i < numbers.Length; i++)
            {
                int j = 1;
                int k = 1;
                sumLeft = 0;
                sumRight = 0;

                while (i - j >= 0)
                {
                    sumLeft += numbers[i - j];
                    j++;
                }
                while (i + k < numbers.Length)
                {
                    sumRight += numbers[i + k];
                    k++;
                }

                if (sumLeft == sumRight && i < numbers.Length)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}