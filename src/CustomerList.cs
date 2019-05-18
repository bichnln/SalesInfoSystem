using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public static class Database
    {
        private static List<Customer> _cList = new List<Customer>();
        private static List<Vehicle> _vList = new List<Vehicle>();
        private static List<SalesInvoice> _siList = new List<SalesInvoice>();
        private static List<Salesperson> _spList = new List<Salesperson>();
        private static List<DealerOption> _optList = new List<DealerOption>();

        public static void AddCustomer(Customer c)
        {
            _cList.Add( c );
        }
        public static void RemoveCustomer(Customer c)
        {
            _cList.Add( c );
        }
        public static List<Customer> FindCustomer(string n)
        {
            List<Customer> Result = new List<Customer>();
            foreach (Customer c in _cList)
            {
                if (c.AreYou(n))
                {
                    Result.Add( c );
                }
            }
            return Result;
        }

        public static void AddVehicle(Vehicle v)
        {
            _vList.Add( v );
            _cList.
        }
      
    }
}
