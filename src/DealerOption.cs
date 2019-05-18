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
        private int _price;

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

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
