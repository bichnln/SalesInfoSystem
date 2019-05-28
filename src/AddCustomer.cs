using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    // form for adding new customer records
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }
        
        private void CancelButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            string firstName = FirstnameTB.Text;
            string lastName = LastnameTB.Text;
            string address = AddressTB.Text;
            string phoneNumber = PhoneTB.Text;

            string msg = "";

            // check if input is valid
            msg += Validation.EmptyCheck( firstName, "First Name" );
            msg += Validation.EmptyCheck( lastName, "Last Name" );
            msg += Validation.EmptyCheck( address, "Address " );
            msg += Validation.PhoneNumberCheck( phoneNumber );

            // if msg is not "", it means the input is invalid
            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else 
            {   
                // save customer's record if the inputs are valid
                Customer c = new Customer( firstName, lastName, address, phoneNumber );
                // add created customer to customer list
                Database.CustomerList.Add( c );
                
                MessageBox.Show( "New customer added!" );
                DialogResult = DialogResult.OK;
            }

        }
    }
}
