using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class SalesInvoice
    {
        private Customer _c;
        private Salesperson _s;
        private List<DealerOption> _optList;
        private Vehicle _v;
        private double _totalPayment;
        private double _tax;
        private double _fees;
        private double _tradeinAllowance;
        private double _negotiatedPrice;
        private Vehicle _tradeV;
        private double _optSum;
       

        private double TaxCalculation()
        {
            double tax;
            tax = 0.1 * (DealerOptionsTotal() + _tradeinAllowance + _fees + _negotiatedPrice);
            return tax;
        }
        private double DealerOptionsTotal()
        {
            double sum = 0;
            foreach (DealerOption o in _optList)
            {
                sum += o.Price;
            }
            return sum;
        }
        public SalesInvoice() { }

        public Customer Cust
        {
            get { return _c; }
            set { _c = value; }
        }
        public Salesperson SPerson
        {
            get { return _s; }
            set { _s = value; }
        }
        public List<DealerOption> OptList
        {
            get { return _optList; }
        }
        public Vehicle V
        {
            get { return _v; }
            set { _v = value; }
        }
        public double TradeInAllowance
        {
            get { return _tradeinAllowance; }
            set { _tradeinAllowance = value; }
        }
        public double FinalPrice
        {
            get { return _totalPayment; }
            set { _totalPayment = _tax + _tradeinAllowance + _fees + DealerOptionsTotal() + _negotiatedPrice; }
        }
        public double Tax
        {
            get { return _tax; }
            set { _tax = TaxCalculation(); }
        }
        public double Fees
        {
            get { return _fees; }
            set { _fees = value; }
        }
        public double NegotiatedPrice
        {
            get { return _negotiatedPrice; }
            set { _negotiatedPrice = value; }
        }
        public string InvoiceDescription()
        {
            string desc;
            desc = "Customer: " + _c.FullName + '\n' + "Salesperson: " + _s.FullName + '\n' + "Purchased vehicle: " + _v.FullDescription()  + "Dealer Options: ";

            foreach (DealerOption o in _optList)
            {
                desc += "\n\t" + o.Code + " - " + o.Price;
            }
            desc += "\nNegotiated Price: " + _negotiatedPrice
                  + "\nTradein Allowance: " + _tradeinAllowance
                  + "\nFees: " + _fees
                  + "\nTax: " + _tax
                  + "\nTotal Payment: " + _totalPayment;

            return desc;
        }
    
    }
}
