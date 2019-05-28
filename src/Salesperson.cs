using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SIS
{
    public class Salesperson : Human
    {
        private string _role = "Salesperson";
        private string _account;
        private string _password;
        public Salesperson(string firstName, string lastName, string address, string phoneNumber) : base(firstName, lastName, address, phoneNumber)
        {
          
            _password = "123456789";
            _account = (firstName + lastName).ToLower();
        }

        public override string Role
        {
            get { return _role; }
        }

        public override string Account
        {
            get { return _account; }
        }
        public override string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}