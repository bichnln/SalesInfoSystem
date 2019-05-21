using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class NewVehicleFactory : VehicleFactory
    {
        private string _name;
        private string _model;
        private string _year;
        private string _baseCost;
        private string _manufacturer;
        public NewVehicleFactory(string name, string model, string year, string baseCost, string manufacturer)
        {
            _name = name;
            _model = model;
            _year = year;
            _baseCost = baseCost;
            _manufacturer = manufacturer;
        }

        public override Vehicle GetVehicle()
        {
            return new NewVehicle( _name, _model, _year, _baseCost, _manufacturer );
        }
    }
}
