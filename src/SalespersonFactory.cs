using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class SalespersonFactory : StaffFactory
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phoneNumber;

        public SalespersonFactory(string firstName, string lastName, string address, string phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phoneNumber = phoneNumber;
        }

        public override Human GetStaff()
        {
            return new Salesperson( _firstName, _lastName, _address, _phoneNumber );
        }
    }
}
