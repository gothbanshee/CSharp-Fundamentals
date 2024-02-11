namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> initialDrums = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            List<int> resultDrums = initialDrums.ToList();
           
            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);
                if (power <= 0)
                {
                    continue;
                }

                for (int i = 0; i < resultDrums.Count; i++)
                {
                    resultDrums[i] -= power;
                    if (resultDrums[i] <= 0)
                    {
                        if (initialDrums[i] * 3 <= money)
                        {
                            resultDrums[i] = initialDrums[i];
                            money -= initialDrums[i] * 3;
                        }
                        else
                        {
                            resultDrums.RemoveAt(i);
                            initialDrums.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", resultDrums));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}