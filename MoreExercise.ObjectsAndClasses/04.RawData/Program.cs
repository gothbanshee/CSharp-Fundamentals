namespace _04.RawData
{
    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public override string ToString()
        {
            return Model;
        }

    }

    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; }
        public int Power { get; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; }
        public string Type { get; }
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

                Car car = new Car(info[0], int.Parse(info[1]), int.Parse(info[2]), int.Parse(info[3]), info[4]);
                cars.Add(car);
            }

            switch (Console.ReadLine())
            {
                case "fragile":
                    cars = cars.Where(c => c.Cargo.Type == "fragile")
                               .Where(c => c.Cargo.Weight < 1000)
                               .ToList();

                    cars.ForEach(c => Console.WriteLine(c));
                    break;
                case "flamable":
                    cars = cars.Where(c => c.Cargo.Type == "flamable")
                               .Where(c => c.Engine.Power > 250)
                               .ToList();

                    cars.ForEach(c => Console.WriteLine(c));
                    break;
            }
        }
    }
}