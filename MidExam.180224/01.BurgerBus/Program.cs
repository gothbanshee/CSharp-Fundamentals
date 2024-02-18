namespace _01.BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCitiesMVT = int.Parse(Console.ReadLine());

            double totalProfitMVT = 0;

            for (int i = 1; i <= totalCitiesMVT; i++)
            {
                string cityNameMVT = Console.ReadLine();
                double cityIncomeMVT = double.Parse(Console.ReadLine());
                double cityExpensesMVT = double.Parse(Console.ReadLine());

                if (i % 5 == 0)
                {
                    cityIncomeMVT *= 0.9;
                }
                else if (i % 3 == 0)
                {
                    cityExpensesMVT *= 1.5;
                }

                double cityProfitMVT = cityIncomeMVT - cityExpensesMVT;
                totalProfitMVT += cityProfitMVT;

                Console.WriteLine($"In {cityNameMVT} Burger Bus earned {cityProfitMVT:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfitMVT:f2} leva.");
        }
    }
}
