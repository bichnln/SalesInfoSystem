using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class TradeInVehicle : Vehicle
    {
        private string _make;
        private string _vehicleType;
        public TradeInVehicle(string name, string model, string year, string make) : base(name, model, year)
        {
            _make = make;
            _vehicleType = "Trade-in Vehicle";
        }
        public override string VehicleType
        {
            get { return _vehicleType; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
    }
}
