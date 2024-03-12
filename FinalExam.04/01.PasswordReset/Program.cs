using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "TakeOdd":
                        StringBuilder sb = new StringBuilder();
                        sb.Capacity = text.Length;

                        for (int i = 0; i < text.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sb.Append(text[i]);
                            }
                        }

                        text = new string(sb.ToString());
                        break;
                    case "Cut":
                        text = text.Remove(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Substitute":
                        if (!text.Contains(command[1]))
                        {
                            Console.WriteLine("Nothing to replace!");
                            continue;
                        }
                        else
                        {
                            text = text.Replace(command[1], command[2]);
                        }
                        break;
                }

                Console.WriteLine(text);
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}
