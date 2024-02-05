namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int days = (int)(centuries * 100 * 365.2422);
            int hours = 24 * days;
            int min = 24 * 60 * days;
            Console.WriteLine($"{centuries} centuries = {centuries * 100} years = {days:f0} days = {hours:f0} hours = {min:f0} minutes");
        }
    }
}
