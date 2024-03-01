namespace _03.SpeedRacing
{
    class Car
    {
        public Car(string model, double fuel, double consumption) 
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
        }

        public string Model { get; }
        public double Fuel { get; }
        public double Consumption { get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
