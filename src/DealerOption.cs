using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class DealerOption
    {
        private string _code;
        private string _description;
        private double _price;

        public DealerOption(string code, string description, string price)
        {
            _code = code;
            _description = description;
            _price = Convert.ToDouble( price );
        }
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
