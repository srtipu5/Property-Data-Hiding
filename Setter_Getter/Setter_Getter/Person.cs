using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setter_Getter
{
    public class Person
    {
        private string firstName;   // setter and getter
        private string lastName;  // setter and getter
        private int age = 18;   // Only setter
        private string gender; // Only setter
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string GetFirstName()
        {
            return "First Name : " + firstName + Environment.NewLine;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string GetLastName()
        {
            return "Last Name : " + lastName + Environment.NewLine;
        }

        public void SetAge(int age)
        {
            if(age >= 18)
            {
                this.age = age;
            }
        }
        public void SetGender(string gender)
        {
            if(gender.ToLower() == "male" || gender.ToLower()=="female")
            {
                this.gender = gender;
            }
        }

        public string GetPersonInfo()
        {
            string info ="------Person Info--------"+ Environment.NewLine +
                         GetFirstName() + GetLastName();
                         info += "Age : " + age + Environment.NewLine +
                         "Gender : " + gender + Environment.NewLine;

            return info;
        }
    }
}
