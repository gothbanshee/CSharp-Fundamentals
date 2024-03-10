namespace _06.StoreBoxes
{
    class Box
    {
        public Box(string serialNumber, string item, int quantity, double price)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
            Price = price;
        }

        public string SerialNumber { get; }
        public string Item { get; }
        public int Quantity { get; }
        public double Price { get; }
        public double TotalPrice => Price * Quantity;

        public override string ToString()
        {
            return $"{SerialNumber}\n-- {Item} - ${Price:f2}: {Quantity}\n-- ${TotalPrice:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                boxes.Add(new Box(command[0], command[1], int.Parse(command[2]), double.Parse(command[3])));
            }

            boxes = boxes.OrderByDescending(b => b.TotalPrice)
                         .ToList();

            boxes.ForEach(Console.WriteLine);
        }
    }
}
