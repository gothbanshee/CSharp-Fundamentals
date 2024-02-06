namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> items = new List<string>();

            for (int i = 0; i < count; i++)
            {
                items.Add(Console.ReadLine());
            }

            items.Sort();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}.{items[i]}");
            }
        }
    }
}
