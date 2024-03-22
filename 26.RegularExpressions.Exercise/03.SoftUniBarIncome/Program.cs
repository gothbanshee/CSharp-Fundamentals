using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Customer
    {
        public Customer(string name, string product, uint count, double price)
        {
            Name = name;
            Product = product;
            Count = count;
            Price = price;
        }

        public string Name { get; }
        public string Product { get; }
        public uint Count { get; }
        public double Price { get; }
        public double TotalPrice => Count * Price;

        public override string ToString()
        {
            return $"{Name}: {Product} - {TotalPrice:f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<Name>[A-Z][a-z]+)\%[^|$.%]*\<(?<Product>\w+)\>[^|$.%]*\|(?<Count>\d+)\|[^|$.%]*?(?<Price>\d+\.\d+|\d+)\$";

            List<Customer> customers = new List<Customer>();

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    customers.Add(new Customer(match.Groups["Name"].Value, match.Groups["Product"].Value, uint.Parse(match.Groups["Count"].Value), double.Parse(match.Groups["Price"].Value)));
                }
            }

            customers.ForEach(Console.WriteLine);
            Console.WriteLine($"Total income: {(customers.Select(c => c.TotalPrice).Sum()):f2}");
        }
    }
}
