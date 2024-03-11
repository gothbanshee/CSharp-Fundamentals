
namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                                        .Split(", ")
                                        .ToArray();

            foreach (var username in usernames)
            {
                if(IsValid(username)) Console.WriteLine(username);
            }
        }

        private static bool IsValid(string username)
        {
            if (username.Length < 3 || username.Length > 16) return false;

            foreach (char c in username)
            {
                if (char.IsLetter(c) || char.IsDigit(c) || "-_".Contains(c)) continue;
                else return false;
            }

            return true;
        }
    }
}
