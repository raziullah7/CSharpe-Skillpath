using System;


namespace PasswordChecker
{
    class Program
    {
        // defining Tools class manually
        public class Tools
        {
            // constructor
            public Tools() { }
            // static Contains method
            public static bool Contains(string target, string list)
            {
                // using IndexOfAny() function on the provided list
                return target.IndexOfAny(list.ToCharArray()) != -1;
            }
        }

        public static void Main(string[] args)
        {
            // defining password characters and constraints
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = ".,~!@#$%^&*()_+-={};:\\'|<>?/`\"";

            // getting input from user
            Console.Write("Enter Password with at least 8 characters : ");
            string password = Console.ReadLine();

            // calculating score for the password
            int score = 0;

            // 1. length check
            if (password.Length >= minLength)
                score += 1;
            // 2. uppercase check
            if (Tools.Contains(password, uppercase))
                score += 1;
            // 3. lowercase check
            if (Tools.Contains(password, lowercase))
                score += 1;
            // 4. digits check
            if (Tools.Contains(password, digits))
                score += 1;
            // 5. special characters check
            if (Tools.Contains(password, specialChars))
                score += 1;

            // additional constraints
            if (password == "password" || password == "1234")
                score = 0;

            // checking results
            Console.WriteLine($"Password Score : {score}/5");

            // finalizing the result
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Extremely Strong Password");
                    break;
                case 3:
                    Console.WriteLine("Strong Password");
                    break;
                case 2:
                    Console.WriteLine("Medium Password");
                    break;
                case 1:
                    Console.WriteLine("Weak Password");
                    break;
                default:
                    Console.WriteLine("The Password Doesn’t Meet Any of the Standards");
                    break;

            }
        }
    }
}
