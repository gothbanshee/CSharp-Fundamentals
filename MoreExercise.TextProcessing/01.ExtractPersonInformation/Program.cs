namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();

                string name = text.Substring(text.IndexOf('@') + 1, text.IndexOf('|') - 1 - text.IndexOf('@'));
                uint age = uint.Parse(text.Substring(text.IndexOf('#') + 1, text.IndexOf('*') - 1 - text.IndexOf('#')));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
