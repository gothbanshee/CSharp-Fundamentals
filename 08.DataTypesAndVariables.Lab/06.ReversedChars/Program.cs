namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[3];
            input[2] = char.Parse(Console.ReadLine());
            input[1] = char.Parse(Console.ReadLine());
            input[0] = char.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
