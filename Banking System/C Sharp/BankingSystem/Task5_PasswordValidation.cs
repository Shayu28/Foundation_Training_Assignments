using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Task5_PasswordValidation
    {
        public static void ValidatePassword()
        {
            Console.Write("Create a password: ");
            string password = Console.ReadLine();

            bool length = password.Length >= 8;
            bool hasDigit = password.Any(char.IsDigit);
            bool hasUpper = password.Any(char.IsUpper);

            if (length && hasDigit && hasUpper)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password must be at least 8 chars, include a digit and an uppercase letter.");
            }
        }
    }

}
