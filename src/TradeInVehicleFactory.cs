using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class TradeInVehicleFactory : VehicleFactory
    {
        private string _name;
        private string _model;
        private string _year;
        private string _make;

        public TradeInVehicleFactory(string name, string model, string year, string make)
        {
            _name = name;
            _model = model;
            _year = year;
            _make = make;
        }

        public override Vehicle GetVehicle()
        {
            return new TradeInVehicle( _name, _model, _year, _make );
        }

    }
}
