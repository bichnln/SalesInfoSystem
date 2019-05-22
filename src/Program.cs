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
            string customerPath = @"C:\Users\SAPPHIRE\Documents\University\Software Architecture & Design\Assignment 2\CustomerList.txt";

            Database.LoadCustomers( customerPath );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new AddCustomer() );

        }
    }
}
