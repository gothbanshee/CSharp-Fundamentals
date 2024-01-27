namespace _01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp1 = int.Parse(Console.ReadLine());
            int emp2 = int.Parse(Console.ReadLine());
            int emp3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hours = 0;

            while (students > 0)
            {
                hours++;
                students -= emp1 + emp2 + emp3;

                if (hours % 4 == 0)
                {
                    students += emp1 + emp2 + emp3;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
