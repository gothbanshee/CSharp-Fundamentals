namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int newNum = numbers[0];
            int newCount = 0;
            int longestNum = numbers[0];
            int longestCount = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == newNum)
                {
                    newCount++;
                    if (newCount > longestCount)
                    {
                        longestCount = newCount;
                        longestNum = newNum;
                    }
                }
                else
                {
                    newNum = numbers[i];
                    newCount = 0;
                }
            }
            for (int i = 0; i <= longestCount; i++)
            {
                Console.Write($"{longestNum} ");
            }
        }
    }
}