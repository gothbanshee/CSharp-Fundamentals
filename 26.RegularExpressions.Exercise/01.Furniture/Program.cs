using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Furniture
    {
        public Furniture(string name, double price, uint quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; }
        public double Price { get; }
        public uint Quantity { get; }
        public double TotalPrice => Price * Quantity;

        public override string ToString()
        {
            return Name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">{2}(?<Name>[A-Za-z]+)<{2}(?<Price>\d+|\d+.\d+)!(?<Quantity>\d+)";
            List<Furniture> furniture = new List<Furniture>();

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    furniture.Add(new Furniture(match.Groups["Name"].Value, double.Parse(match.Groups["Price"].Value), uint.Parse(match.Groups["Quantity"].Value)));
                }
            }

            Console.WriteLine("Bought furniture:");
            furniture.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {(furniture.Select(f => f.TotalPrice).DefaultIfEmpty().Sum()):f2}");
        }
    }
}
