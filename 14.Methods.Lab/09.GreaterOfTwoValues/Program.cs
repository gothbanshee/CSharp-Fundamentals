namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                GetMax(Console.ReadLine(), Console.ReadLine());
            }
            else if (type == "char")
            {
                GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
            }
            else
            {
                GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }

        }

        private static void GetMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        private static void GetMax(char first, char second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        private static void GetMax(string? first, string? second)
        {
            int result = first.CompareTo(second);

            if (result > 0)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
    }
}