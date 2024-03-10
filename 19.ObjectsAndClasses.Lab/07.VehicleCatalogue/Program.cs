namespace _07.VehicleCatalogue
{
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Type { get; }
        public string Brand { get; }
        public string Model { get; }
        public int HorsePower { get; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; }
        public string Model { get; }
        public int Weight { get; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split('/');

                if (command[0] == "Car") cars.Add(new Car(command[1], command[2], int.Parse(command[3])));
                else trucks.Add(new Truck(command[1], command[2], int.Parse(command[3])));
            }

            cars = cars.OrderBy(c => c.Brand)
                       .ToList();

            trucks = trucks.OrderBy(t => t.Brand)
                           .ToList();

            Console.WriteLine("Cars:");
            cars.ForEach(Console.WriteLine);

            Console.WriteLine("Trucks:");
            trucks.ForEach(Console.WriteLine);
        }
    }
}
