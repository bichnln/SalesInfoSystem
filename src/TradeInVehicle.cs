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

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
    }
}
