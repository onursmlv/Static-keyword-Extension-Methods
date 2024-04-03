using System;
using System.Collections.Generic;
using System.Text;

namespace Static_keyword__Extension_Methods
{
    class Person
    {
        public static string Name { get; set; }

        public int Age { get; set; }

        static Person()
        {
            Console.WriteLine("Static ctor is working.");
        }


        public Person()
        {
            Console.WriteLine("Default ctor is working.");
            Age = 1;
        }

        public Person(string name)
        {
            Console.WriteLine("With parametr ctor is working.");
        }




        //public string _name { get; set; }

        //public static void showInfo()
        //{
        //    Console.WriteLine($"{Name} {_name}");
        //}
    }
}
