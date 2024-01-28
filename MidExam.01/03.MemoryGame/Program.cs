namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .Split();

            string input;
            int moves = 1;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] indexes = input.Split();
                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);

                if(firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0 || firstIndex >= elements.Length || secondIndex >= elements.Length)
                {
                    //add new elements ??? -{moves}a
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                if (elements[firstIndex] == elements[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}");
                    // delete the items ????
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                moves++;
            }
        }
    }
}
