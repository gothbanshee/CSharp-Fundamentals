namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input.Split(":|:");

                switch (command[0])
                {
                    case "InsertSpace":
                        text = text.Insert(int.Parse(command[1]), " ");
                        break;
                    case "Reverse":
                        if (!text.Contains(command[1]))
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        else
                        {
                            char[] sub = command[1].ToCharArray();
                            Array.Reverse(sub);
                            string substring = new string(sub);
                            text = text.Remove(text.IndexOf(command[1]));
                            text = string.Concat(text, substring);
                        }
                        break;
                    case "ChangeAll":
                        text = text.Replace(command[1], command[2]);
                        break;
                }

                Console.WriteLine(text);
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
