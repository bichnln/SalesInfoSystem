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
        public static List<Human> StaffList = new List<Human>();
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
                    Console.WriteLine( vehicle.Name );
                    Console.WriteLine( VehicleList[0].Name );
                }
            }
            
            file.Close();
        }

        public static void LoadStaff(string filePath)
        {
            /*string line;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split( ',' );
                StaffList.Add( new Human( words[0], words[1], words[2], words[3], words[4] ) );
            }

            file.Close();*/
        }

        public static void LoadDealOptions()
        {
            string filePath = FilePath.DealOptListPath;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                OptionList.Add( new DealerOption(words[0], words[1], words[2]) );
            }
            file.Close();
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

        public static void SaveVehicleList()
        {
            string filePath = FilePath.VehicleListPath;
            System.IO.StreamWriter file = new System.IO.StreamWriter( filePath );
            
            foreach (Vehicle v in VehicleList)
            {
                if (v.VehicleType == "New Vehicle")
                {
                    NewVehicle temp = (NewVehicle)v;
                    file.WriteLine( temp.VehicleType + ',' + temp.Name + ',' + temp.Model + ',' + temp.Year + ',' + temp.BaseCost + ',' + temp.Manufacturer );
                }

                if (v.VehicleType == "Trade-in Vehicle")
                {
                    TradeInVehicle temp = (TradeInVehicle)v;
                    file.WriteLine( temp.VehicleType + ',' + temp.Name + ',' + temp.Model + ',' + temp.Year + ',' + temp.Make );
                }
            }

            file.Close();
        }

        public static void SaveDealerOptions()
        {
            string filePath = FilePath.DealOptListPath;
            System.IO.StreamWriter file = new System.IO.StreamWriter( filePath );

            foreach (DealerOption o in OptionList)
            {
                file.WriteLine( o.Code + ',' + o.Description + ',' + o.Price);
            }
            file.Close();
        }
    }
}
