using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class Customer : Human
    {
        private string _role;

        public Customer(string firstName, string lastName, string address, string phoneNumber) : base(firstName, lastName, address, phoneNumber)
        {
            _role = "Customer";
        }

        public override string Role
        {
            get { return _role; }
        }

        public override string Account => throw new NotImplementedException();
        public override string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
