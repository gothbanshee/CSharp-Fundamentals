namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double outfall = 39.99;
            double cs = 15.99;
            double zplinter = 19.99;
            double honored = 59.99;
            double rw = 29.99;
            double rwOrigin = 39.99;

            double balance = Double.Parse(Console.ReadLine());
            double spent = balance;
            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                if (balance > 0.00)
                {
                    switch (game)
                    {
                        case "OutFall 4":
                            if (balance >= outfall)
                            {
                                Console.WriteLine("Bought OutFall 4");
                                balance -= outfall;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;

                        case "CS: OG":
                            if (balance >= cs)
                            {
                                Console.WriteLine("Bought CS: OG");
                                balance -= cs;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;

                        case "Zplinter Zell":
                            if (balance >= zplinter)
                            {
                                Console.WriteLine("Bought Zplinter Zell");
                                balance -= zplinter;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;

                        case "Honored 2":
                            if (balance >= honored)
                            {
                                Console.WriteLine("Bought Honored 2");
                                balance -= honored;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;

                        case "RoverWatch":
                            if (balance >= rw)
                            {
                                Console.WriteLine("Bought RoverWatch");
                                balance -= rw;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;

                        case "RoverWatch Origins Edition":
                            if (balance >= rwOrigin)
                            {
                                Console.WriteLine("Bought RoverWatch Origins Edition");
                                balance -= rwOrigin;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;

                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            spent -= balance;
            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
        }
    }
}
