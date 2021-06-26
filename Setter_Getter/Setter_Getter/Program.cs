using System;

namespace Setter_Getter
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

            Console.Write("Enter Your Gender : ");
            string gender = Console.ReadLine();

            Person person = new Person();
            person.SetFirstName(firstName);
            Console.Write(person.GetFirstName());

            person.SetLastName(lastName);
            Console.WriteLine(person.GetLastName());

            person.SetAge(age);

            person.SetGender(gender);

            Console.WriteLine(person.GetPersonInfo());

            Console.ReadKey();
        }
    }
}
