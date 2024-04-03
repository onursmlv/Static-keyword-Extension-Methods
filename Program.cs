using System;

namespace Static_keyword__Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Math.Sum(3, 5));

            //int test = 5;
            //test.Sum(3);

            //string email = "test#gmail.com";

            //Console.WriteLine(email.CheckEmailValidation());

            Student student = new Student();
            student.FullName = "Onur Ismailov";
            student.GroupNo = "P601";
            student.Age = 30;

            #region Static

            //Person.Name = "Ali";

            //Person.Name = "Coshgun";

            //Person.Name = "Samir";


            //Person person = new Person();
            //person._name = "Ali";

            //Person person2 = new Person();
            //person2._name = "Coshgun";

            //Person person3 = new Person();
            //person3._name = "Samir";

            //Console.WriteLine(Person.Name);

            //Console.WriteLine(person._name);

            //Console.WriteLine(person2._name);

            //Console.WriteLine(person3._name);

            //person.showInfo();
            //person2.showInfo();
            //person3.showInfo();

            #endregion

        }

        #region
        //public static void ShowInfo(string info)
        //{
        //    Console.WriteLine(info);
        //}

        //Math math = new Math();

        //Console.WriteLine(Math.Sum(3, 5));

        //Program program = new Program();
        //program.ShowInfo("Test");
        //ShowInfo("Test");

        //Person.Name = "Test";
        //Person person = new Person();

        //Person person1 = new Person("Test");
        #endregion

    }
}
