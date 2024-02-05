namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = null;
            for (int i = 0; i < 3; i++)
            {
                output += char.Parse(Console.ReadLine());
            }
            Console.WriteLine(output);
        }
    }
}
