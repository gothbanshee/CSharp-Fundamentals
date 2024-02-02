namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grades(double.Parse(Console.ReadLine()));

            static void Grades(double input)
            {
                if (input < 3)
                {
                    Console.WriteLine("Fail");
                }
                else if (input < 3.5)
                {
                    Console.WriteLine("Poor");
                }
                else if (input < 4.5)
                {
                    Console.WriteLine("Good");
                }
                else if (input < 5.5)
                {
                    Console.WriteLine("Very good");
                }
                else
                {
                    Console.WriteLine("Excellent");
                }
            }
        }
    }
}
