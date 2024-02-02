namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "water":
                    Console.WriteLine($"{(quantity * 1.00):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(quantity * 1.40):f2}");
                    break;
                case "coffee":
                    Console.WriteLine($"{(quantity * 1.50):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(quantity * 2.00):f2}");
                    break;
            }
        }
    }
}
