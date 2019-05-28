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
        public static List<Invoice> InvoiceList = new List<Invoice>();
        public static List<DealerOption> OptionList = new List<DealerOption>();

        public static void LoadCustomers( )
        {
            string filePath = FilePath.CustomerListPath;
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
            string filePath = FilePath.VehicleListPath;
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

                    if (words[6].ToLower() == "true")
                    {
                        vehicle.IsSold = true;
                    }
                    else
                    {
                        vehicle.IsSold = false;
                    }
                    VehicleList.Add( vehicle );

                }
                else if (words[0] == "Trade-in Vehicle")
                {
                    factory = new TradeInVehicleFactory( words[1], words[2], words[3], words[4] );
                    vehicle = factory.GetVehicle();
                    if (words[5].ToLower() == "true")
                    {
                        vehicle.IsSold = true;
                    }
                    else
                    {
                        vehicle.IsSold = false;
                    }
                    VehicleList.Add( vehicle );
                }
            }

            file.Close();
        }

        public static void LoadStaff()
        {
            string filePath = FilePath.StaffListPath;
            string line;
            StaffFactory factory;
            Human staff;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split( ',' );
                if (words[0] == "Salesperson")
                {
                    factory = new SalespersonFactory( words[1], words[2], words[3], words[4] );
                    staff = factory.GetStaff();
                    staff.Password = words[6];
                    StaffList.Add( staff );
                }
                else if (words[0] == "Management Staff")
                {
                    factory = new ManagementStaffFactory( words[1], words[2], words[3], words[4] );
                    staff = factory.GetStaff();
                    staff.Password = words[6];
                    StaffList.Add( staff );
                }
            }
            file.Close();
        }

        public static void LoadDealOptions()
        {
            string filePath = FilePath.DealOptListPath;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split( ',' );
                OptionList.Add( new DealerOption( words[0], words[1], words[2] ) );
            }
            file.Close();
        }

        public static void LoadInvoiceList()
        {
            string filePath = FilePath.InvoiceListPath;
            System.IO.StreamReader file = new System.IO.StreamReader( filePath );

            string iCount = file.ReadLine();

            if ( iCount != null)
            {
                int invoiceCount = Convert.ToInt32( iCount );
                for (int i = 0; i < invoiceCount; i++)
                {
                    Invoice invoice = new Invoice();
                    string[] customer = file.ReadLine().Split( ',' );
                    invoice.Cust = new Customer( customer[0], customer[1], customer[2], customer[3] );

                    string[] sales = file.ReadLine().Split( ',' );
                    invoice.SPerson = new Salesperson( sales[0], sales[1], sales[2], sales[3] );

                    // Read vehicle
                    string[] vehicleInfo = file.ReadLine().Split( ',' );
                    VehicleFactory factory;
                    Vehicle vehicle;
                    if (vehicleInfo[0] == "New Vehicle")
                    {
                        factory = new NewVehicleFactory( vehicleInfo[1], vehicleInfo[2], vehicleInfo[3], vehicleInfo[4], vehicleInfo[5] );
                        vehicle = factory.GetVehicle();

                        invoice.PurchasedVehicle = vehicle;

                    }
                    else if (vehicleInfo[0] == "Trade-in Vehicle")
                    {
                        factory = new TradeInVehicleFactory( vehicleInfo[1], vehicleInfo[2], vehicleInfo[3], vehicleInfo[4] );
                        vehicle = factory.GetVehicle();

                        invoice.PurchasedVehicle = vehicle;
                    }

                    string nPrice = file.ReadLine();
                    invoice.NegotiatedPrice = Convert.ToDouble( nPrice );

                    string[] tradedV = file.ReadLine().Split( ',' );
                    if (tradedV[0] != "Trade-in Vehicle")
                    {
                        invoice.TradedVehicle = null;
                        invoice.TradeInAllowance = 0;
                        file.ReadLine(); // skip trade-in allowance
                    }
                    else
                    {
                        invoice.TradedVehicle = new TradeInVehicle( tradedV[1], tradedV[2], tradedV[3], tradedV[4] );
                        invoice.TradeInAllowance = Convert.ToDouble( file.ReadLine() );
                    }

                    int optCount = Convert.ToInt32( file.ReadLine() );
                    for (int k = 0; k < optCount; k++)
                    {
                        string[] option = file.ReadLine().Split( ',' );
                        invoice.OptList.Add( new DealerOption( option[0], option[1], option[2] ) );
                    }

                    int feeCount = Convert.ToInt32( file.ReadLine() );
                    for (int j = 0; j < feeCount; j++)
                    {
                        string[] fee = file.ReadLine().Split( ',' );
                        invoice.FeeList.Add( new Fee( fee[0], fee[1] ) );
                    }

                    string isPaid = file.ReadLine();
                    if (isPaid.ToLower() == "true")
                    {
                        invoice.IsPaid = true;
                    }
                    else if (isPaid.ToLower() == "false")
                    {
                        invoice.IsPaid = false;
                    }

                    InvoiceList.Add( invoice );
                }
            }

            file.Close();

        }
        public static void SaveCustomerList( )
        {
            string filePath = FilePath.CustomerListPath;
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
                    file.WriteLine( temp.VehicleType + ',' + temp.Name + ',' + temp.Model + ',' + temp.Year + ',' + temp.BaseCost + ',' + temp.Manufacturer + ',' + temp.IsSold.ToString()); 
                }

                else if (v.VehicleType == "Trade-in Vehicle")
                {
                    TradeInVehicle temp = (TradeInVehicle)v;
                    file.WriteLine( temp.VehicleType + ',' + temp.Name + ',' + temp.Model + ',' + temp.Year + ',' + temp.Make + ',' + temp.IsSold.ToString() );
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
                file.WriteLine( o.Code + ',' + o.Description + ',' + o.Price );
            }
            file.Close();
        }

        public static void SaveStaffList()
        {
            string filePath = FilePath.StaffListPath;

            System.IO.StreamWriter file = new System.IO.StreamWriter( filePath );

            foreach (Human s in StaffList)
            {
                if (s.Role == "Salesperson")
                {
                    Salesperson temp = (Salesperson)s;
                    file.WriteLine( temp.Role + ',' + temp.FirstName + ',' + temp.LastName + ',' + temp.Address + ',' + temp.PhoneNumber + ',' + temp.Account + ',' + temp.Password);
                }

                if (s.Role == "Management Staff")
                {
                    ManagementStaff temp = (ManagementStaff)s;
                    file.WriteLine( temp.Role + ',' + temp.FirstName + ',' + temp.LastName + ',' + temp.Address + ',' + temp.PhoneNumber + ',' + temp.Account.ToLower() + ',' + temp.Password.ToLower() );
                }
            }

            file.Close();
        }

        public static void SaveInvoiceList()
        {
            string filePath = FilePath.InvoiceListPath;

            System.IO.StreamWriter file = new System.IO.StreamWriter( filePath );

            file.WriteLine( InvoiceList.Count.ToString() );
            foreach (Invoice i in InvoiceList)
            {
                file.WriteLine( i.Cust.FirstName + ',' + i.Cust.LastName + ',' + i.Cust.Address + ',' + i.Cust.PhoneNumber );
                file.WriteLine( i.SPerson.FirstName + ',' + i.SPerson.LastName + ',' + i.SPerson.Address + ',' + i.SPerson.PhoneNumber);
                if (i.PurchasedVehicle.VehicleType == "New Vehicle")
                {
                    NewVehicle v = (NewVehicle)i.PurchasedVehicle;
                    file.WriteLine( v.VehicleType + ',' + v.Name + ',' + v.Model + ',' + v.Year + ',' + v.BaseCost + ',' + v.Manufacturer);
                }
                else
                {
                    TradeInVehicle v = (TradeInVehicle)i.PurchasedVehicle;
                    file.WriteLine( v.VehicleType + ',' + v.Name + ',' + v.Model + ',' + v.Year + ',' + v.Make );
                }
                file.WriteLine( i.NegotiatedPrice );
                // save traded vehicle info
                if (i.TradedVehicle != null)
                {
                    file.WriteLine( i.TradedVehicle.VehicleType + ',' + i.TradedVehicle.Name + ',' + i.TradedVehicle.Model + ',' + i.TradedVehicle.Year + ',' + i.TradedVehicle.Make );

                    file.WriteLine( i.TradeInAllowance.ToString());
                }
                else
                {
                    file.WriteLine( "0" );
                    file.WriteLine( "0" );
                }

                int optionCount = i.OptList.Count();
                file.WriteLine( optionCount );
                if (optionCount > 0)
                {
                    for (int k = 0; k < optionCount; k++)
                    {
                        file.WriteLine(i.OptList[k].Code + ',' + i.OptList[k].Description + ',' + i.OptList[k].Price.ToString());
                    }
                }

                int feeCount = i.FeeList.Count();
                file.WriteLine( feeCount );
                if (feeCount > 0)
                {
                    for (int j = 0; j < feeCount; j++)
                    {
                        file.WriteLine( i.FeeList[j].Name + ',' + i.FeeList[j].Price.ToString());
                    }
                }
                if (i.IsPaid == true)
                {
                    file.WriteLine( "true" );
                }
                else
                {
                    file.WriteLine( "false" );
                }
            }

            file.Close();
        }




    }
}
