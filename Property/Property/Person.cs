
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string gender;

        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return "First Name : " + firstName;
            }

        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return "Last Name : " + lastName;
            }

        }

        public int Age 
        {
            set
            {
                if(value >= 18)
                {
                    age = value;
                }
      
            }
            get
            {
                return  age;
            }
        
        }
        public string Gender
        {
            set
            {
                if (value.ToLower()=="male" || value.ToLower() == "female")
                {
                    gender = value;
                }
            }
            get
            {
                return "Gender : " + gender;
            }

        }

    }
}
