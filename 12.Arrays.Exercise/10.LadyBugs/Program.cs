namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 1000)
            {
                return;
            }

            int[] field = new int[n];

            int[] positions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if (positions.Length > field.Length)
            {
                Console.WriteLine(String.Join(" ", field));
                return;
            }

            foreach (int position in positions)
            {
                if (position >= field.Length || position < 0)
                {
                    continue;
                }
                field[position] = 1;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end" || command.Length < 3)
                {
                    break;
                }

                int position = int.Parse(command[0]);
                if (position < 0)
                {
                    continue;
                }
                if (position >= field.Length || field[position] == 0)
                {
                    continue;
                }

                bool direction = true;
                if (command[1] == "left")
                {
                    direction = false;
                }

                int fly = int.Parse(command[2]);
                if (fly < 0)
                {
                    direction = !direction;
                }
                fly = Math.Abs(int.Parse(command[2]));

                field[position] = 0;
                int newPosition;
                if (direction)
                {
                    newPosition = position + fly;

                    if (newPosition < 0 || newPosition > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[newPosition] == 1)
                    {
                        while (field[newPosition] == 1)
                        {
                            newPosition += fly;
                            if (newPosition < 0 || newPosition > field.Length - 1)
                            {
                                break;
                            }
                        }
                        if (newPosition < 0 || newPosition > field.Length - 1)
                        {
                            continue;
                        }
                        else
                        {
                            field[newPosition] = 1;
                        }
                    }
                    else
                    {
                        field[newPosition] = 1;
                    }
                }
                else
                {
                    newPosition = position - fly;

                    if (newPosition < 0 || newPosition > field.Length - 1)
                    {
                        continue; // check if it works properly;
                    }

                    if (field[newPosition] == 1)
                    {
                        while (field[newPosition] == 1)
                        {
                            newPosition -= fly;
                            if (newPosition < 0 || newPosition > field.Length - 1)
                            {
                                break;
                            }
                        }
                        if (newPosition < 0 || newPosition > field.Length - 1)
                        {
                            continue;
                        }
                        else
                        {
                            field[newPosition] = 1;
                        }
                    }
                    else
                    {
                        field[newPosition] = 1;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}