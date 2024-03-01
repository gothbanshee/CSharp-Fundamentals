namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Dictionary<string, string> allUsers = new Dictionary<string, string>();

            for (int i = 0; i < length; i++)
            {
                string[] userInfo = Console.ReadLine()
                                           .Split()
                                           .ToArray();


                switch (userInfo[0])
                {
                    case "register":
                        string username = userInfo[1];
                        string licensePlate = userInfo[2];
                        if (allUsers.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {allUsers[username]}");
                            continue;
                        }

                        allUsers.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                        break;
                    case "unregister":
                        username = userInfo[1];

                        if (!allUsers.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                            continue;
                        }

                        allUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                        break;
                }
            }

            foreach (var keyValuePair in allUsers)
            {
                Console.WriteLine($"{keyValuePair.Key} => {keyValuePair.Value}");
            }
        }
    }
}