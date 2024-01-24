namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) 
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
/*
1 2 3 4 5 6

3 5 7 9

2 4 6 8 10

*/