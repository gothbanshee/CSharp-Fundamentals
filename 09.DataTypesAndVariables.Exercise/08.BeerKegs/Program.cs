namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;
            string print = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                if ((Math.PI * radius * radius * height) > volume)
                {
                    volume = Math.PI * radius * radius * height;
                    print = model;
                }
            }
            Console.WriteLine(print);
        }
    }
}
