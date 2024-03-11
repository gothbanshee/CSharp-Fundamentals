namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;

            foreach (char c in text)
            {
                if (c > start && c < end) sum += c;
            }

            Console.WriteLine(sum);
        }
    }
}
