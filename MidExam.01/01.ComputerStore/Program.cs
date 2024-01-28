namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double sum = 0;

            while (type != "special" && type != "regular")
            {
                double cost = double.Parse(type);

                if (cost >= 0.00)
                {
                    sum += cost;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
                type = Console.ReadLine();
            }
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (type == "special")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {(sum * 0.20):f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {((sum * 1.20) - ((sum * 1.20) * 0.10)):f2}$");
            }
            else if (type == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {(sum * 0.20):f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(sum * 1.20):f2}$");
            }
        }
    }
}
