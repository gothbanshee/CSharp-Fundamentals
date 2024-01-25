namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = count * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = count * 9.80;
                }
                else
                {
                    price = count * 10.46;
                }
                if (count >= 30)
                {
                    price = price * 0.85;// -15%
                }
            }
            else if (type == "Business")
            {
                if (count >= 100)
                {
                    count -= 10; // 10 free                        
                }
                if (day == "Friday")
                {
                    price = count * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = count * 15.60;
                }
                else
                {
                    price = count * 16;
                }

            }
            else
            {
                if (day == "Friday")
                {
                    price = count * 15;
                }
                else if (day == "Saturday")
                {
                    price = count * 20;
                }
                else
                {
                    price = count * 22.50;
                }
                if (count >= 10 && count <= 20)
                {
                    price = price * 0.95;// -5%
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
