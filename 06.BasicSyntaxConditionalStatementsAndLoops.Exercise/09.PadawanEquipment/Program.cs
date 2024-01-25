namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double spent = (Math.Ceiling(students * 1.10) * lightsaber) + (students * robes) + ((students - (students / 6)) * belts);

            if (spent <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {spent:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(spent - money):f2}lv more.");
            }
        }
    }
}
