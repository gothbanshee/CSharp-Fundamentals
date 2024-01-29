namespace _01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double daily = int.Parse(Console.ReadLine());
            double target = int.Parse(Console.ReadLine());
            double gained = 0;

            for (int i = 1; i <= days; i++)
            {
                gained += daily;

                if (i % 3 == 0)
                {
                    gained += daily / 2;
                }
                if (i % 5 == 0)
                {
                    gained *= 0.70;
                }
            }
            if (gained >= target)
            {
                Console.WriteLine($"Ahoy! {gained:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {((gained * 100) / target):f2}% of the plunder.");
            }
        }
    }
}
