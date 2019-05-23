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
    public partial class EditCustomer : Form
    {
        public Customer selected;
        public EditCustomer( ref Customer c )
        {
            InitializeComponent();
            selected = c;

            FirstnameTB.Text = selected.FirstName;
            LastnameTB.Text = selected.LastName;
            AddressTB.Text = selected.Address;
            PhoneTB.Text = selected.PhoneNumber;

        }

        private void FirstnameTB_TextChanged( object sender, EventArgs e )
        {

        }

        
        private void CancelButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FirstnameTB_TextChanged_1( object sender, EventArgs e )
        {
           
        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string firstName = FirstnameTB.Text;
            string lastName = LastnameTB.Text;
            string address = AddressTB.Text;
            string phoneNumber = PhoneTB.Text;

            string msg = "";

            DialogResult = DialogResult.None;

            // check if input is valid
            msg += Validation.EmptyCheck( firstName, FirstnameLabel.Text );
            msg += Validation.EmptyCheck( lastName, LastnameLabel.Text );
            msg += Validation.EmptyCheck( address, AddressLabel.Text );
            msg += Validation.PhoneNumberCheck( phoneNumber );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                selected.FirstName = firstName;
                selected.LastName = lastName;
                selected.Address = address;
                selected.PhoneNumber = phoneNumber;

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
