namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double accepted = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);
                switch (coin)
                {
                    case 0.1:
                        accepted += 0.1;
                        break;
                    case 0.2:
                        accepted += 0.2;
                        break;
                    case 0.5:
                        accepted += 0.5;
                        break;
                    case 1:
                        accepted += 1.0;
                        break;
                    case 2:
                        accepted += 2.0;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        if (accepted >= 2.0)
                        {
                            accepted -= 2.0;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (accepted >= 0.7)
                        {
                            accepted -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (accepted >= 1.5)
                        {
                            accepted -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (accepted >= 0.8)
                        {
                            accepted -= 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (accepted >= 1.0)
                        {
                            accepted -= 1.0;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {accepted:f2}");
        }
    }
}
