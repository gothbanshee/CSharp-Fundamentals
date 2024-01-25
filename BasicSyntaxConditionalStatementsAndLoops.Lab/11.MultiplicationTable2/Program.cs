namespace _11.MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            if (start > 10)
            {
                Console.WriteLine($"{num} X {start} = {num * start}");
                return;
            }

            for (int i = start; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
