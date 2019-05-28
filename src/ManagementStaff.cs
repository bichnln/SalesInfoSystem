using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class ManagementStaff : Human
    {
        private string _role = "Management Staff";
        private string _account;
        private string _password;

        public ManagementStaff(string firstName, string lastName, string address, string phoneNumber ) : base(firstName, lastName, address, phoneNumber)
        {
            _account = (firstName + lastName).ToLower();
            _password = "123456789";
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
