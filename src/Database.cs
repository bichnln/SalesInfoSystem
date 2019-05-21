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
        public static void LoadVehicles(string filePath)
        {
            string line;
            VehicleFactory factory;
            Vehicle vehicle;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split( ',' );
                if (words[0] == "New Vehicle")
                {
                    factory = new NewVehicleFactory( words[1], words[2], words[3], words[4], words[5] );
                    vehicle = factory.GetVehicle();
                    VehicleList.Add( vehicle );

                }
                else if (words[0] == "Trade-in Vehicle")
                {
                    factory = new TradeInVehicleFactory( words[1], words[2], words[3], words[4] );
                    vehicle = factory.GetVehicle();
                    VehicleList.Add( vehicle );
                }
            }
            file.Close();
        }

        public static void LoadSalesPeople(string filePath)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split( ',' );
                SalespersonList.Add( new Salesperson( words[0], words[1], words[2], words[3] ) );
            }

            file.Close();
        }

        public static void LoadDealOptions(string filePath)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                OptionList.Add( new DealerOption(words[0], words[1], words[2]) );
            }
        }
        public static void SaveCustomerList( string filePath )
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter( filePath );

            foreach (Customer c in CustomerList)
            {
                file.WriteLine( c.FirstName + ',' + c.LastName + ',' + c.Address + ',' + c.PhoneNumber );
            }
            file.Close();
        }
    }
}
