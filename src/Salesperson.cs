using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SIS
{
    public class Salesperson : Human
    {
        private string _position;
        public Salesperson(string firstName, string lastName, string address, string phoneNumber, string position) : base(firstName, lastName, address, phoneNumber)
        {
            _position = position;
        }

        public string Position
        {
            get { return _position; }
        }
    }
}