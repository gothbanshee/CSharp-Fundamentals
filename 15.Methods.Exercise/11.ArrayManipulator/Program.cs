namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initial = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "exchange":
                        if (IndexOutOfArray(initial, command))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        initial = Exchange(initial, command);
                        break;
                    case "max":
                        if (GetMax(initial, command) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(GetMax(initial, command));
                        }
                        break;
                    case "min":
                        if (GetMin(initial, command) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(GetMin(initial, command));
                        }
                        break;
                    case "first":
                        if (CountBiggerThanArray(initial, command))
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        if ((FirstFew(initial, command)) == null)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{String.Join(", ", FirstFew(initial, command))}]");
                        }
                        break;
                    case "last":
                        if (CountBiggerThanArray(initial, command))
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        if ((LastFew(initial, command)) == null)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.WriteLine($"[{String.Join(", ", LastFew(initial, command))}]");
                        }
                        break;
                }
            }

            Console.WriteLine($"[{String.Join(", ", initial)}]");
        }

        static int[] Exchange(int[] initial, string[] command)
        {
            int[] changed = new int[initial.Length];
            int newIndex = int.Parse(command[1]) + 1;

            for (int i = 0; i < changed.Length; i++)
            {
                if (newIndex < 0 || newIndex >= initial.Length)
                {
                    newIndex = 0;
                }

                changed[i] = initial[newIndex];
                newIndex++;
            }

            return changed;
        }

        static int[] FirstFew(int[] initial, string[] command)
        {
            int count = 0;
            foreach (int number in initial)
            {
                if (command[2] == "even" && number % 2 == 0)
                {
                    count++;
                }
                else if (command[2] == "odd" && number % 2 != 0)
                {
                    count++;
                }
            }

            if (count > int.Parse(command[1]))
            {
                count = int.Parse(command[1]);
            }
            else if (count == 0)
            {
                return null;
            }

            int[] firstFew = new int[count];
            int lastIndex = -1;
            for (int i = 0; i < firstFew.Length; i++)
            {
                for (int j = lastIndex + 1; j < initial.Length; j++)
                {
                    if (command[2] == "even" && initial[j] % 2 == 0)
                    {
                        firstFew[i] = initial[j];
                        lastIndex = j;
                        break;
                    }
                    else if (command[2] == "odd" && initial[j] % 2 != 0)
                    {
                        firstFew[i] = initial[j];
                        lastIndex = j;
                        break;
                    }
                }
            }
            return firstFew;
        }

        static int[] LastFew(int[] initial, string[] command)
        {
            int count = 0;
            foreach (int number in initial)
            {
                if (command[2] == "even" && number % 2 == 0)
                {
                    count++;
                }
                else if (command[2] == "odd" && number % 2 != 0)
                {
                    count++;
                }
            }

            if (count > int.Parse(command[1]))
            {
                count = int.Parse(command[1]);
            }
            else if (count == 0)
            {
                return null;
            }

            int[] lastFew = new int[count];
            int lastIndex = initial.Length;
            for (int i = lastFew.Length - 1; i >= 0; i--)
            {
                for (int j = lastIndex - 1; j >= 0; j--)
                {
                    if (command[2] == "even" && initial[j] % 2 == 0)
                    {
                        lastFew[i] = initial[j];
                        lastIndex = j;
                        break;
                    }
                    else if (command[2] == "odd" && initial[j] % 2 != 0)
                    {
                        lastFew[i] = initial[j];
                        lastIndex = j;
                        break;
                    }
                }
            }
            return lastFew;
        }

        static int GetMax(int[] initial, string[] command)
        {
            int max = int.MinValue;
            int maxIndex = 0;
            bool numFound = false;

            for (int i = 0; i < initial.Length; i++)
            {
                if (command[1] == "even" && initial[i] % 2 == 0)
                {
                    if (initial[i] >= max)
                    {
                        numFound = true;
                        maxIndex = i;
                        max = initial[i];
                    }
                }
                else if (command[1] == "odd" && initial[i] % 2 != 0)
                {
                    if (initial[i] >= max)
                    {
                        numFound = true;
                        maxIndex = i;
                        max = initial[i];
                    }
                }
            }
            if (numFound == false)
            {
                return -1;
            }
            else
            {
                return maxIndex;
            }
        }

        static int GetMin(int[] initial, string[] command)
        {
            int min = int.MaxValue;
            int minIndex = 0;
            bool numFound = false;

            for (int i = 0; i < initial.Length; i++)
            {
                if (command[1] == "even" && initial[i] % 2 == 0)
                {
                    if (initial[i] <= min)
                    {
                        numFound = true;
                        minIndex = i;
                        min = initial[i];
                    }
                }
                else if (command[1] == "odd" && initial[i] % 2 != 0)
                {
                    if (initial[i] <= min)
                    {
                        numFound = true;
                        minIndex = i;
                        min = initial[i];
                    }
                }
            }
            if (numFound == false)
            {
                return -1;
            }
            else
            {
                return minIndex;
            }
        }

        static bool IndexOutOfArray(int[] initial, string[] command)
        {
            if ((int.Parse(command[1])) < 0 || (int.Parse(command[1])) >= initial.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CountBiggerThanArray(int[] initial, string[] command)
        {
            if ((int.Parse(command[1])) < 1 || (int.Parse(command[1])) > initial.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}