namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[1] = Console.ReadLine();

            Console.WriteLine(String.Join("", names));
        }
    }
}
