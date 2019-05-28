using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class Fee
    {
        private string _name;
        private double _price;

        public Fee(string name, string price)
        {
            _name = name;
            _price = Convert.ToDouble( price );
        }

        public string Name
        {
            get { return _name; }
        }

        public double Price
        {
            get { return _price; }
        }
    }
}
