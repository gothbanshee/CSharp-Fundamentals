namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] command = input.Split('|');

                switch (command[0])
                {
                    case "ChangeAll":
                        while (text.Contains(command[1]))
                        {
                            text = text.Replace(command[1], command[2]);
                        }
                        break;
                    case "Insert":
                        text = text.Insert(int.Parse(command[1]), command[2]);
                        break;
                    case "Move":
                        text = text.Substring(int.Parse(command[1])) + text.Substring(0, int.Parse(command[1]));
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
