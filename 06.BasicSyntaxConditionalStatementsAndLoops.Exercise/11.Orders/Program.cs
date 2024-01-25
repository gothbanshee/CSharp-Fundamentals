namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < orders; i++)
            {
                double pricePerCap = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                double price = ((days * capsules) * pricePerCap);
                total += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
