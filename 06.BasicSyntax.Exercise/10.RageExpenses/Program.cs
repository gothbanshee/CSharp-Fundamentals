namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            double total = 0.00;

            total = ((lostGames / 2) * headset) + ((lostGames / 3) * mouse) + ((lostGames / 6) * keyboard) + ((lostGames / 12) * display);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
