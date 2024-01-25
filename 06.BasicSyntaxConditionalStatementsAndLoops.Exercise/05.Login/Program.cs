namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = ""; //reverse
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            int tries = 0;

            while (
                tries <= 4)
            {
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                tries++;
                if (tries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }
        }
    }
}
