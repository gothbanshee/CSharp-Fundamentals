namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int spices = 0;

            while (yield >= 100)
            {
                spices += yield;
                yield -= 10;
                days++;

                if (spices >= 26)
                {
                    spices -= 26;
                }
                else
                {
                    break;
                }
            }

            if (spices >= 26)
            {
                spices -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(spices);
        }
    }
}
