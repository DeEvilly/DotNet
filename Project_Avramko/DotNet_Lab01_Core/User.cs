using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Lab01_Core
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private DateTime _registeredAt;

        public User() { }

        public User(string firstName, string lastName, int age, DateTime registeredAt)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegisteredAt = registeredAt;
        }

        public string FirstName
        { 
            get { return _firstName; } 
            set { if (!string.IsNullOrWhiteSpace(value)) _firstName = value; } 
        }

        public string LastName
        { 
            get { return _lastName; } 
            set { if (!string.IsNullOrWhiteSpace(value)) _lastName = value; }
        }
        
        public int Age
        { 
            get { return _age; } 
            set { if (value > 0) _age = value; }
        }

        public DateTime RegisteredAt
        { 
            get { return _registeredAt; } 
            set { _registeredAt = value; }
        }

        public override string ToString()
        {
            return $"User: {FirstName} {LastName}, Age: {Age}, Registered At: {RegisteredAt}";
        }
    }
}
