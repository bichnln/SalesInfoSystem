using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public abstract class Vehicle
    {
        private string _name;
        private string _model;
        private string _year;
        private bool _isSold = false;

        public Vehicle(string name, string model, string year)
        {    
            _name = name;
            _model = model;
            _year = year;
        }

        public abstract string VehicleType
        {
            get;
        }
        
        public abstract string SerialNumber
        {
            get;
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

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public bool IsSold
        {
            get { return _isSold; }
            set { _isSold = value; }
        }
        public string FullDescription()
        {
            string fullDesc;
            fullDesc = "Name: " + _name + '\n'
                     + "Model: " + _model + '\n'
                     + "Year: " + _year + '\n';

            return fullDesc;
        }
    }
}
