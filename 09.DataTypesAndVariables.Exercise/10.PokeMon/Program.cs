namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());
            int count = 0;
            double half = power;

            while (power >= distance)
            {
                if (half / power == 2.00 && factor != 0)
                {
                    power /= factor;
                }
                if (power >= distance)
                {
                    power -= distance;
                }
                else
                {
                    break;
                }
                count++;
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
