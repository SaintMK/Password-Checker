using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {


            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "!@#$%^&*";
            int score = 0;
            string[] nonoWords = { "password", "Password", "Passwurd", "passwurd", "12345678" };


            while (score <= 2)
            {

                string input = Console.ReadLine();

                if (input.Length >= minLength) score++;
                if (input.Length < minLength) Console.WriteLine("Password must be 8 characters or more.\n");

                if (Tools.Contains(input, uppercase) == true) score++;
                if (Tools.Contains(input, lowercase) == true) score++;
                if (Tools.Contains(input, digits) == true) score++;
                if (Tools.Contains(input, specialChars) == true) score++;

                foreach (string i in nonoWords)
                {
                    if (i == input)
                    {
                        score = 0;
                        Console.WriteLine($"Password cannot be {input}");
                    }
                }

                if (score == 1)
                {
                    Console.WriteLine("Your password is very weak.\n");
                }

                else if (score == 2)
                {
                    Console.WriteLine("Your password is weak.\n");
                }

                else if (score == 3)
                {
                    Console.WriteLine("Your password is average.\n");
                }

                else if (score == 4)
                {
                    Console.WriteLine("Your password is strong");
                }

                else if (score == 5)
                {
                    Console.WriteLine("Your password is very strong.\n");
                }

                else if (score == 0)
                {
                    Console.WriteLine("Input a password");
                }

                Console.WriteLine($"Score: {score}");

            }

        }
    }
}
