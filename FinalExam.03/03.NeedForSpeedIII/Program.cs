namespace _03.NeedForSpeedIII
{
    class Car
    {
        public Car(string name, uint mileage, uint fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Name { get; set; }
        public uint Mileage { get; set; }
        public uint Fuel { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split('|')
                                          .ToArray();

                cars.Add(new Car(command[0], uint.Parse(command[1]), uint.Parse(command[2])));
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split(" : ");

                string name = command[1];

                switch (command[0])
                {
                    case "Drive":
                        uint distance = uint.Parse(command[2]);
                        uint fuel = uint.Parse(command[3]);

                        if (cars.First(c => c.Name == name).Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            Console.WriteLine($"{cars.First(c => c.Name == name).Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            cars.First(c => c.Name == name).Fuel -= fuel;
                            cars.First(c => c.Name == name).Mileage += distance;

                            if (cars.First(c => c.Name == name).Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {cars.First(c => c.Name == name).Name}!");
                                cars.Remove(cars.First(c => c.Name == name));
                            }
                        }
                        break;
                    case "Refuel":
                        Console.WriteLine($"{cars.First(c => c.Name == name).Name} refueled with {Math.Min(uint.Parse(command[2]), 75 - cars.First(c => c.Name == name).Fuel)} liters");

                        cars.First(c => c.Name == name).Fuel += uint.Parse(command[2]);
                        cars.First(c => c.Name == name).Fuel = Math.Min(75, cars.First(c => c.Name == name).Fuel);
                        break;
                    case "Revert":
                        cars.First(c => c.Name == name).Mileage -= uint.Parse(command[2]);
                        if (cars.First(c => c.Name == name).Mileage < 10000)
                        {
                            cars.First(c => c.Name == name).Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{cars.First(c => c.Name == name).Name} mileage decreased by {uint.Parse(command[2])} kilometers");
                        }
                        break;
                }
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}
