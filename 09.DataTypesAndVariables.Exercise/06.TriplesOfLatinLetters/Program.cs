namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.Write((char)('a' + k));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
