using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class Invoice
    {
        private Customer _c;
        private Salesperson _s;
        private List<DealerOption> _optList;
        private Vehicle _v;
        private List<Fee> _feeList;
        private double _totalPayment;
        private double _tax;
        private double _totalFees;
        private double _tradeinAllowance = 0;
        private double _negotiatedPrice;
        private TradeInVehicle _tradeV;


        private bool _isPaid;
       

        private double TaxCalculation()
        {
            _tax = 0.1 * (TotalDealerOptionPrice + _tradeinAllowance + TotalFees + _negotiatedPrice);
            return _tax;
        }
        private double DealerOptionCalculation()
        {
            double sum = 0;
            foreach (DealerOption o in _optList)
            {
                sum += o.Price;
            }
            return sum;
        }
        private double TotalFeesCalculation()
        {
            double fPrice = 0;

            foreach (Fee f in _feeList)
            {
                fPrice += f.Price;
            }

            return fPrice;
        }
        public double TotalPaymentCalculation()
        {
            _totalPayment = Tax + TradeInAllowance + TotalFees + TotalDealerOptionPrice + NegotiatedPrice;

            return _totalPayment;
        }
        public Invoice()
        {
            _optList = new List<DealerOption>();
            _feeList = new List<Fee>();
            _isPaid = false;
        }

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
        public List<Fee> FeeList
        {
            get { return _feeList; }
        }
        public Vehicle PurchasedVehicle
        {
            get { return _v; }
            set { _v = value; }
        }
        public TradeInVehicle TradedVehicle
        {
            get { return _tradeV; }
            set { _tradeV = value; }
        }
        public double TradeInAllowance
        {
            get { return _tradeinAllowance; }
            set { _tradeinAllowance = value; }
        }
        public double TotalPayment
        {
            get { return TotalPaymentCalculation(); }
        }
        public double Tax
        {
            get { return TaxCalculation(); }
        }
        public double TotalFees
        {
            get { return TotalFeesCalculation(); }
        }
        public double TotalDealerOptionPrice
        {
            get { return DealerOptionCalculation(); }
        }
        public double NegotiatedPrice
        {
            get { return _negotiatedPrice; }
            set { _negotiatedPrice = value; }
        }
        public string CustomerName
        {
            get
            {
                if (_c == null)
                {
                    return null;
                }
                else 
                    return _c.FullName;
            }
        }
        public string PurchasedVehicleName
        {
            get
            {
                if (_v == null)
                {
                    return null;
                }
                else
                    return _v.Name;
            }
        }
        public string TradeInVehicleName
        {
            get
            {
                if (_tradeV == null)
                {
                    return null;
                }
                else
                    return _tradeV.Name;
            }
        }
        public string SalespersonName
        {
            get
            {
                if (_s == null)
                {
                    return null;
                }
                else
                    return _s.FullName;
            }
        }
        public bool IsPaid
        {
            get { return _isPaid; }
            set { _isPaid = value; }
        }
       /*public string InvoiceDescription()
        {
            string desc;
            desc = "Customer: " + _c.FullName + '\n' + "Salesperson: " + _s.FullName + '\n' + "Purchased vehicle: " + _v.FullDescription()  + "Dealer Options: ";

            foreach (DealerOption o in _optList)
            {
                desc += "\n\t" + o.Code + " - " + o.Price;
            }
            desc += "\nNegotiated Price: " + _negotiatedPrice
                  + "\nTradein Allowance: " + _tradeinAllowance
                  + "\nTotal Dealer Options Price: " + this.TotalDealerOptionPrice 
                  + "\nFees: " + this.TotalFees
                  + "\nTax: " + this.Tax
                  + "\nTotal Payment: " + this.TotalPayment;

            return desc;
        }*/    
    }
}
