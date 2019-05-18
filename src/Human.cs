using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public abstract class Human
    {
        private string _id;
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phoneNumber;

        public Human(string firstName, string lastName, string address, string phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phoneNumber = phoneNumber;
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public bool AreYou(string name)
        {
            name = name.ToLower();

            if ((_firstName.ToLower().Contains(name)) || (_lastName.ToLower().Contains(name)))
            {
                return true;
            }
            else
                return false;
        }

    }
}
