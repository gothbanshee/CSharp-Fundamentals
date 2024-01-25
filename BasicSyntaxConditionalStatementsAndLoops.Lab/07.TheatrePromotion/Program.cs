namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day  = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            double price = 0;

            if (age >= 0 && age <= 18 )
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                else if (day == "weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age >= 19 && age <= 64)
            {
                if (day == "weekday")
                {
                    price = 18;
                }
                else if (day == "weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age >= 65 && age <= 122)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                else if (day == "weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
