using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class ManagementStaff : Human
    {
        private string _role;

        public ManagementStaff(string firstName, string lastName, string address, string phoneNumber ) : base(firstName, lastName, address, phoneNumber)
        {
            _role = "Staff";
        }

        public override string Role
        {
            get { return _role; }
        }
    }
}
