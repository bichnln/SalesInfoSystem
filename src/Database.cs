using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIS
{
    public static class Database
    {
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Salesperson> SalespersonList = new List<Salesperson>();
        public static List<Vehicle> VehicleList = new List<Vehicle>();
        public static List<SalesInvoice> InvoiceList = new List<SalesInvoice>();
        public static List<DealerOption> OptionList = new List<DealerOption>();

        public static void LoadCustomers(string filePath)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split( ',' );
                CustomerList.Add( new Customer( words[0], words[1], words[2], words[3] ) );
            }

            file.Close();
        }
        public static void LoadVehicles()
        {

        }

        public static void LoadSalesPeople()
        {

        }

        public static void LoadDealOptions()
        {

        }
    }
}
