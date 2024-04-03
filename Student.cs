using System;
using System.Collections.Generic;
using System.Text;

namespace Static_keyword__Extension_Methods
{
    internal class Student
    {
        private static string _fullName;
        private static string _groupNo;
        private int _age;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (CheckFullname(value))
                {
                    _fullName = value;
                }
                else
                {
                    Console.WriteLine("Telebe Ad Sehvdir");
                }
            }
        }
        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                    Console.WriteLine("Ad set olundu");
                }
                else
                {
                    Console.WriteLine("Ad Sehvdir");
                }
            }
        }
        public int Age { get; set; }

        public static bool CheckGroupNo(string value)
        {
            if (value.Length == 4)
            {
                int count = 0;

                for (int i = 0; value.Length > i; i++)
                {
                    if (char.IsUpper(value[i]) && i == 0)
                    {
                        count++;
                    }
                    else if (char.IsDigit(value[i]))
                    {
                        count++;
                    }
                }
                return count == 4 ? true : false;
            }
            return false;
        }

        public static bool CheckFullname(string value)
        {
            for (int i = 0; value.Length > i; i++)
            {
                int count = 0;
                if (char.IsUpper(value[i]) && i == 0)
                {
                    count++;
                }
                else if (char.IsWhiteSpace(value[i]) && value[i + 1] != ' ')
                {
                    count++;
                    if (char.IsUpper(value[i + 1]))
                    {
                        count++;
                    }
                }
                return count == 3 ? true : false;

            }
            return false;
        }

    }
}
