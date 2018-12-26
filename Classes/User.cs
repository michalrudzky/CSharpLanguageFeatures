using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        private static int amountOfUsers;

        // Fields

        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        // Properties
        public string Name
        {
            get
            {
                if (firstName != null && lastName != null)
                    return $"{firstName} {lastName}";

                return "NA";
            }
        }

        public string Password
        {
            set { password = value; }
        }

        // Property as a lambda expression
        public int Age => birthDate != default(DateTime) ? DateTime.Now.Year - birthDate.Year : default(int);


        // Constructor
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User()
        {
        }


        // Methods
        public void SetPersonalInfo(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            birthDate = dateOfBirth;
        }

        public bool CheckPassword(string password)
        {
            return password == this.password;
        }
    }
}
