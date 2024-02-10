using System;

namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            List<int> removed = new List<int>();

            int index;
            while (pokemons.Count > 0)
            {
                index = int.Parse(Console.ReadLine());
                if (IndexLessThanZero(index))
                {
                    index = 0;
                    IncreaseDecreaseAndRemove(pokemons, removed, index);
                    pokemons.Reverse();
                    pokemons.Add(pokemons[0]);
                    pokemons.Reverse();
                }
                else if (IndexBiggerThanArray(pokemons, index))
                {
                    index = 0;
                    pokemons.Reverse();
                    IncreaseDecreaseAndRemove(pokemons, removed, index);
                    pokemons.Reverse();
                    pokemons.Add(pokemons[0]);
                }
                else
                {
                    IncreaseDecreaseAndRemove(pokemons, removed, index);
                }
            }

            Console.WriteLine(removed.Sum());
        }

        static void IncreaseDecreaseAndRemove(List<int> pokemons, List<int> removed, int index)
        {
            removed.Add(pokemons[index]);
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (i == index)
                {
                    continue;
                }

                if (pokemons[i] > pokemons[index])
                {
                    pokemons[i] -= pokemons[index];
                }
                else
                {
                    pokemons[i] += pokemons[index];
                }
            }
            pokemons.RemoveAt(index);
        }

        static bool IndexLessThanZero(int index)
        {
            return index < 0;
        }

        static bool IndexBiggerThanArray(List<int> pokemons, int index)
        {
            return index >= pokemons.Count;
        }
    }
}
