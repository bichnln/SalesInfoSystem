using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    class Program
    {
        static void Main( string[] args )
        {
            Database.LoadCustomers();
            Database.LoadVehicles();
            Database.LoadDealOptions();
            Database.LoadInvoiceList();
            Database.LoadStaff();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new Login() );
        }
    }
}

            