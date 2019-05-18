using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class Customer : Human
    {
        public Customer(string firstName, string lastName, string address, string phoneNumber) : base(firstName, lastName, address, phoneNumber)
        {

        }
    }
}
