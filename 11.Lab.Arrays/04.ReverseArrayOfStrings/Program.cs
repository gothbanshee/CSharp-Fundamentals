namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length / 2; i++)
            {
                string first = input[i];
                string last = input[input.Length - 1 - i];

                input[i] = last;
                input[input.Length - 1 - i] = first;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
/*
a b c d e

-1 hi ho w

 */