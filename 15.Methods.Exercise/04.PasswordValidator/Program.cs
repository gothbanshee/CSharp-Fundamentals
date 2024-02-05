

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!LengthCheck(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CharCheck(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (DigitCheck(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (LengthCheck(password) && CharCheck(password) && DigitCheck(password) >= 2)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static int DigitCheck(string password)
        {
            int count = 0;
            foreach (char letter in password)
            {
                if (Char.IsNumber(letter))
                {
                    count++;
                }
            }
            return count;
        }

        private static bool CharCheck(string password)
        {
            foreach (char letter in password)
            {
                if (!Char.IsLetter(letter) && !Char.IsNumber(letter))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool LengthCheck(string password)
        {
            if (password.Length > 5 && password.Length < 11)
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
