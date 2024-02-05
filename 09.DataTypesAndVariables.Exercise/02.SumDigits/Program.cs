namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;

            while (num > 0)
            {
                total += num % 10;
                num /= 10;
            }
            Console.WriteLine(total);
        }
    }
}
