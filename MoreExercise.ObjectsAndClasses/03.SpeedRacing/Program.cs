namespace _03.SpeedRacing
{
    class Car
    {
        public Car(string model, double fuel, double consumption, double travelledDistance)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            TravelledDistance = travelledDistance;
        }

        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        public double TravelledDistance { get; set; }

        public void HasEnoughFuel(double distance)
        {
            if(Fuel >= (distance * Consumption))
            {
                Fuel -= distance * Consumption;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {TravelledDistance}";
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
                string[] info = Console.ReadLine()
                                       .Split()
                                       .ToArray();

                Car car = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]), 0);
                cars.Add(car);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                string carModel = command[1];
                double distance = double.Parse(command[2]);

                cars.First(c => c.Model == carModel).HasEnoughFuel(distance);
            }

            cars.ForEach(c => Console.WriteLine(c));
        }
    }
}