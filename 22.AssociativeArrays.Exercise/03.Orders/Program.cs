namespace _03.Orders
{
    class Product
    {
        public Product(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public void Update(double price, double quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {(Price * Quantity):f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split();

                string name = command[0];
                double price = double.Parse(command[1]);
                double quantity = double.Parse(command[2]);

                Product product = new Product(name, price, quantity);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, product);
                }
                else
                {
                    products[name].Update(price, quantity);
                }
            }

            foreach (var keyValuePair in products)
            {
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}