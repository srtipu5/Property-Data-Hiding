using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Your Last Name : ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Gender : ");
            string gender = Console.ReadLine();

            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Age = age;
            person.Gender = gender;

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);

            Console.WriteLine("Age : " + person.Age);
            Console.WriteLine(person.Gender);

            Console.ReadKey();

        }
    }
}
