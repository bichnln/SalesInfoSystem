﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SIS
{
    public class Salesperson : Human
    {
        private string _role;
        public Salesperson(string firstName, string lastName, string address, string phoneNumber) : base(firstName, lastName, address, phoneNumber)
        {
           _role = "Salesperson";
        }

        public override string Role
        {
            get { return _role; }
        }
    }
}