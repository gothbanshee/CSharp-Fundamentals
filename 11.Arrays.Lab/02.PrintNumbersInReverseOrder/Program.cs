namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < numbers.Length; i++)
            {
                Console.Write($"{numbers[numbers.Length - 1 - i]} ");
            }
        }
    }
}