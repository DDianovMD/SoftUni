using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;
            bool CheckNotPassed = false;
            isValid = NumbersOfCharactersChecker(password, isValid);
            if (isValid == false)
            {
                CheckNotPassed = true;
            }
            isValid = TypeOfCharactersChecker(password, isValid);
            if (isValid == false)
            {
                CheckNotPassed = true;
            }
            isValid = NumbersOfDigitsChecker(password, isValid);
            if (isValid == false)
            {
                CheckNotPassed = true;
            }
            if (isValid == true && CheckNotPassed == false)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool NumbersOfCharactersChecker(string password, bool isValid)
        {
            isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return isValid = false;                
            }
            else
            {
                return isValid = true;
            }
        }
        static bool TypeOfCharactersChecker(string password, bool isValid) // 48, 57, 65, 90, 97, 122
        {
            isValid = true;
            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    isValid = true;
                }
                else if ((int)password[i] >= 65 && (int)password[i] <= 90)
                {
                    isValid = true;
                }
                else if ((int)password[i] >= 97 && (int)password[i] <= 122)
                {
                    isValid = true;
                }
                else
                {                    
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
        static bool NumbersOfDigitsChecker(string password, bool isValid)
        {
            isValid = true;
            int sum = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                if ((int)currentChar >= 48 && (int)currentChar <= 57)
                {
                    sum += 1;
                }
            }

            if (sum >= 2)
            {
                return isValid = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return isValid = false;
            }            
        }
    }
}
