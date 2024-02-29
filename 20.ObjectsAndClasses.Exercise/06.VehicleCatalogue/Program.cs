namespace _06.VehicleCatalogue
{
    internal class Program
    {
        internal class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsepower)
            {
                char first = char.ToUpper(type.First());
                type = first + type.Substring(1);

                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsepower;
            }

            public string Type { get; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }

            public override string ToString()
            {
                return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
            }
        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                Vehicle newVehicle = new Vehicle(command[0], command[1], command[2], int.Parse(command[3]));
                vehicles.Add(newVehicle);

            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehicle = vehicles.FirstOrDefault(v => v.Model == input);

                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle);
                }
            }

            Console.WriteLine($"Cars have average horsepower of: {vehicles.Where(vehicle => vehicle.Type == "Car").Select(vehicle => vehicle.HorsePower).DefaultIfEmpty().Average():f2}.");

            Console.WriteLine($"Trucks have average horsepower of: {vehicles.Where(vehicle => vehicle.Type == "Truck").Select(vehicle => vehicle.HorsePower).DefaultIfEmpty().Average():f2}.");
        }
    }
}