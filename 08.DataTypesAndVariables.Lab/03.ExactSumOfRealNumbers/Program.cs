namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine($"{total}");
        }
    }
}
