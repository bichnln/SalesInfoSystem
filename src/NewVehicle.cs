using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class NewVehicle : Vehicle
    {
        private string _vehicleType;
        private string _manufacturer;
        private double _baseCost;

        public NewVehicle( string name, string model, string year, string baseCost, string manufacturer) : base (name, model, year)
        {
            _baseCost = Convert.ToDouble(baseCost);
            _manufacturer = manufacturer;
            _vehicleType = "New Vehicle";
        }
        public override string VehicleType
        {
            get { return _vehicleType; }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public override string SerialNumber
        {
            get { return "N" + Name[0] + Name[1] + Model[0] + Model[1] + Manufacturer[0] + Manufacturer[2]  + Year; }
        }

        public double BaseCost
        {
            get { return _baseCost; }
            set { _baseCost = value; }
        }

    }
}
