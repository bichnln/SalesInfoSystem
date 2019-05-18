using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public abstract class Vehicle
    {
        private string _serialNumber;
        private string _name;
        private string _model;
        private int _year;

        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public bool IsInYear(int y)
        {
            if (_year == y)
            {
                return true;
            }
            else return false;
        }
        public bool HasName(string n)
        {
            if (_name.ToLower().Contains( n ))
            {
                return true;
            }
            else return false;
        }
    }
}
