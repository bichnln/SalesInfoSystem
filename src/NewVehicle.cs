using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class NewVehicle : Vehicle
    {
        private string _manufacturer;
        private int _baseCost;

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public int BaseCost
        {
            get { return _baseCost; }
            set { _baseCost = value; }
        }

    }
}
