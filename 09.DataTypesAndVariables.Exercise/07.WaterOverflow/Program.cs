namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters + total > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    total += liters;
                }
            }
            Console.WriteLine(total);
        }
    }
}
