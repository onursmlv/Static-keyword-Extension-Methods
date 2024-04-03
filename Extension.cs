using System;
using System.Collections.Generic;
using System.Text;

namespace Static_keyword__Extension_Methods
{
    internal static class Extension
    {
        public static void Sum(this int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        public static bool CheckEmailValidation(this string email)
        {
            return email.Contains("@");
        }

    }
}
