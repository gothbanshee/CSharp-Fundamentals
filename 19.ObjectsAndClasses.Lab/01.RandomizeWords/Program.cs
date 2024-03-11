namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                                   .Split()
                                   .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                int rndIndex = rnd.Next(text.Length);

                string temp = text[i];
                string word = text[rndIndex];

                text[i] = word;
                text[rndIndex] = temp;
            }

            Console.WriteLine(String.Join("\n", text));
        }
    }
}
