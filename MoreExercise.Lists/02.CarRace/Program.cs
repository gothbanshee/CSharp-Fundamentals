namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] route = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            float leftTime = TotalTime(route);
            route = route.Reverse().ToArray();
            float rightTime = TotalTime(route);

            if (rightTime < leftTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
        }

        static float TotalTime(int[] route)
        {
            float sum = 0;
            for (int i = 0; i < route.Length / 2; i++)
            {
                if (route[i] == 0)
                {
                    sum *= 0.80f;
                }
                else
                {
                    sum += route[i];
                }
            }
            return sum;
        }
    }
}
