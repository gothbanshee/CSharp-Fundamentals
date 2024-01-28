namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double max = 0;
            double maxAt = 0;

            for (int i = 0; i < students; i++)
            {
                double attends = int.Parse(Console.ReadLine());
                double total = Math.Ceiling((attends / lectures) * (5 + bonus));

                if (total > max)
                {
                    max = total;
                    maxAt = attends;
                }
            }
            Console.WriteLine($"Max Bonus: {max}.");
            Console.WriteLine($"The student has attended {maxAt} lectures.");
        }
    }
}
